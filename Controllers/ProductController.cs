


namespace ASMMAIN.Controllers
{

    using Microsoft.AspNetCore.Mvc;
    using System; 
    using Microsoft.AspNetCore.Authorization; 
    using Microsoft.AspNetCore.Identity;
    public class ProductController : Controller
    {

        [AllowAnonymous]
        
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