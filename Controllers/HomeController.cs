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

namespace ASMMAIN.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ShopContext context;
        public HomeController(ILogger<HomeController> logger , ShopContext _context)
        {
            _logger = logger;
            context = _context;
        }

        public async Task<IActionResult> Index(int? id)
        {
            ViewData["categories"] = await context.categories.ToListAsync();

            if(id == null) { 

                 return View(await context.products.ToListAsync());

            }else { 
                var products = await context.products.Select(x => x).Where(x => x.category_id == id).ToListAsync();
                return View(products);
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
    }
}
