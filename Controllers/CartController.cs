


namespace ASMMAIN.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using ASMMAIN.Models;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Newtonsoft.Json;
    using Microsoft.AspNetCore.Identity;
    using System.Security.Claims;
    using Microsoft.AspNetCore.Authorization;
    using System;
    [Route("/cart/[action]")]
    public class CartController : Controller
    {

        private readonly ShopContext context;

        private readonly UserManager<User> userManager;
        public CartController(ShopContext context , UserManager<User> userManager)
        {
            this.context = context;
            this.userManager = userManager;
        }

        [Route("/cart")]
        [Authorize]
        public async Task<IActionResult> Index()
        {
            ViewBag.user =await  userManager.GetUserAsync(User);
            var carts = SessionHelper.GetObjectFormJson<List<CartItem>>(HttpContext.Session , "cart");
            if(carts != null) { 
                ViewBag.total = carts.Sum(x => x.product.price * x.Quantity);
                ViewBag.sumprice = ViewBag.total + 2000;
            }
            return View(carts);
        }

        
        private int isExist(int? id){ 
         List<CartItem> carts = SessionHelper.GetObjectFormJson<List<CartItem>>(HttpContext.Session , "cart");
            for(int i = 0; i<carts.Count;i++){ 
                if(carts[i].product.product_id.Equals(id)){ 
                    return i;
                }
            }
            return -1;
        }

          public async Task<IActionResult> Add(int? id) { 
            ProductModel model = new ProductModel(context); 

            if(SessionHelper.GetObjectFormJson<List<CartItem>>(HttpContext.Session , "cart") ==null){
                List<CartItem> carts = new List<CartItem>(); 
                carts.Add(new CartItem {product = await model.Find(id) , Quantity = 1  });
                SessionHelper.SetObjectAsJson(HttpContext.Session , "cart" , carts);
            }else { 
                List<CartItem> carts = SessionHelper.GetObjectFormJson<List<CartItem>>(HttpContext.Session , "cart");
                int index = isExist(id);
                if(index != -1){
                    carts[index].Quantity++;
                }else{
                    carts.Add(new CartItem{product = await model.Find(id) , Quantity = 1});
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session , "cart" , carts);
            }
            return NoContent();

        }


         public IActionResult Remove(int? id){
            List<CartItem> carts = SessionHelper.GetObjectFormJson<List<CartItem>>(HttpContext.Session , "cart");
            int index = isExist(id);
            carts.RemoveAt(index);
             System.Console.WriteLine(index);

            SessionHelper.SetObjectAsJson(HttpContext.Session , "cart" , carts);
            return NoContent();
        }

        [TempData]
        public string Message {get;set;}

        [TempData]
        public string MessageType {get;set;}

        [TempData]

        public DateTime date {get;set;}
        public async Task<IActionResult> History(string userID = null){ 
            
            List<Cart> carts;

            var user = await userManager.FindByIdAsync(userID);
        
            ViewBag.fullname = user.FullName;
            Console.WriteLine(user.FullName);
            if(userID != null) { 

                 carts = await context.carts.Select(x => x).Where(x=> x.UserId == userID).OrderByDescending(x=> x.created_date).ToListAsync() ;
            }else{

             carts = await context.carts.OrderByDescending(x => x.created_date).ToListAsync();
            }
            foreach(var item in carts) { 
               item.items = JsonConvert.DeserializeObject<List<CartItem>>(item.productList);
            }
            return View(carts);
        }
        public async Task<IActionResult> SaveCart(float totalprice){
            
            
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var carts = SessionHelper.GetObjectFormJson<List<CartItem>>(HttpContext.Session , "cart");
            date = DateTime.Now;
            await context.AddAsync(new Cart{productList = JsonConvert.SerializeObject(carts) , created_date = date, total = totalprice,
                UserId = userId , status = true
            });
            await context.SaveChangesAsync();
            HttpContext.Session.Clear();
            Message = "Đặt hàng thành công vui lòng chờ nhận hàng!";
            MessageType = AlertModel.Type.success;
            
            return RedirectToAction(nameof(History),new {userId = userId});
        }
    }
}