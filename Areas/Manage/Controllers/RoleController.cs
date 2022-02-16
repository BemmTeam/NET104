
namespace ASMMAIN.Controllers
{

    using Microsoft.AspNetCore.Mvc;
    using System;
    using Microsoft.AspNetCore.Identity;
    using ASMMAIN.Models;

    [Route("/manage/role/[Action]")]
    public class RoleController : Controller
    {

        private readonly RoleManager<IdentityRole> roleManager; 
        private readonly UserManager<User> userManager; 

        private ShopContext ShopContext;

     


      
        
        public RoleController(RoleManager<IdentityRole> roleManager, UserManager<User> userManager, ShopContext shopContext)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
            ShopContext = shopContext;
            
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome()
        {
            ViewData["Message"] = "Your welcome message";

            return View();
        }
    }
}