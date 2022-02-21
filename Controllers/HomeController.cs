using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ASMMAIN.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
namespace ASMMAIN.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ShopContext context;

        private readonly UserManager<User> userManager;
        public HomeController(ILogger<HomeController> logger , ShopContext _context , UserManager<User> _usermanager)
        {
            _logger = logger;
            context = _context;
            this.userManager = _usermanager;
        }

        public async Task<IActionResult> Index(int? id , string nameproduct ,int num , string Order =  "Theo tên"  , string TypeOder = "Tăng dần" )
        {
            
            ViewData["num"] = num + 1;
             var carts = SessionHelper.GetObjectFormJson<List<CartItem>>(HttpContext.Session , "cart");
              if(carts != null) { 
                ViewBag.total = carts.Sum(x => x.product.price * x.Quantity);
                ViewBag.sum = carts.Sum(x=> x.Quantity);
            }
            ViewData["cart"] = carts;
            ViewData["categories"] = await context.categories.ToListAsync();
            
            if(nameproduct != null) { 

                var products = await context.products.Select(x => x).Where(x => x.name.Contains(nameproduct)).ToListAsync();
                 return View(FilterProduct(products,Order,TypeOder));
            }

            if(id == null) { 

                 return View( FilterProduct(await context.products.ToListAsync(), Order , TypeOder ));

            }else { 
                
                var products = await context.products.Select(x => x).Where(x => x.category_id == id).ToListAsync();
                 return View( FilterProduct(products, Order , TypeOder));
            }
        }

        private List<Product> FilterProduct(List<Product> products,string Order , string TypeOder)  { 
            
             var carts = SessionHelper.GetObjectFormJson<List<CartItem>>(HttpContext.Session , "cart");
            if(carts != null) { 

                    foreach(var item in carts) { 

                        foreach(var itemproduct in products) { 

                            if(itemproduct.product_id == item.product.product_id) itemproduct.quantity -= item.Quantity;
                        }
                    }

            }

            if(Order.Contains("Theo giá")) { 

                if(TypeOder.Contains("Tăng dần")) { 
                    
                    return products.OrderBy(x=> x.price).ToList();
                }else { 
                    return  products.OrderByDescending(x=> x.price).ToList();
                    
                }
                
            }else {
                   if(TypeOder.Contains("Tăng dần")) { 
                    
                    return products.OrderBy(x=> x.name).ToList();
                }else { 
                    return products.OrderByDescending(x=> x.name).ToList();
                    
                }
            }
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public async Task<IActionResult> detail(int? id){ 
            
             var carts = SessionHelper.GetObjectFormJson<List<CartItem>>(HttpContext.Session , "cart");
              if(carts != null) { 
                ViewBag.total = carts.Sum(x => x.product.price * x.Quantity);
                ViewBag.sum = carts.Sum(x=> x.Quantity);
            }
            ViewData["cart"] = carts;
            
            if(id == null) {
                return NotFound();
            }else {
                var product = await context.products.FindAsync(id);
                    if(carts != null) { 

                            foreach(var item in carts) { 

                               

                                    if(product.product_id == item.product.product_id) product.quantity -= item.Quantity;
                                
                            }

                    }
                return View(product);
            }
        }

        
        [Authorize]
        public async Task<IActionResult> InfoUser(){ 

            var user = await userManager.GetUserAsync(User);
            return View(user);
        }

        [HttpGet]
        [Authorize]

        public async Task<IActionResult> UpdateUser(){ 

            var user = await userManager.GetUserAsync(User);
            
            return View(user);
        }

        [TempData] 
        public string Message {get;set;}

        [TempData]

        public string MessageType {get;set;}

         [HttpPost]
        [Authorize]

        public async Task<IActionResult> UpdateUser(string id ,User user){ 
            
             var findUser = await userManager.FindByIdAsync(id);
                    findUser.HomeAddress = user.HomeAddress ; 
                    findUser.FullName = user.FullName; 
                    findUser.UserName = user.UserName;
                    findUser.Email = user.Email ; 
                    findUser.PhoneNumber = user.PhoneNumber; 
                   var result = await userManager.UpdateAsync(findUser);
                   if(result.Succeeded) { 
                       Message = "Cập nhật thông tin thành công";
                       return RedirectToAction(nameof(InfoUser));
                   }else { 
                       Message = result.ToString();
                       MessageType = AlertModel.Type.error;
                   }
                     return View(user);
        }
    }
}
