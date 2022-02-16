namespace ASMMAIN.Areas.Controllers
{

    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Identity;
    using ASMMAIN.Models;
    using ASMMAIN;
    using System.Threading.Tasks;
    using ASMMAIN.Areas.Models;
    [Area("manage")]
    public class AccountController : Controller
    {
        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        private  UserManager<User> userManager { get;set;}
        private  SignInManager<User> signInManager {get;set;}

        
        [HttpGet("/manage/account")]
        // public async Task<IActionResult> Index()
        // {
        
        // }

        public IActionResult Welcome()
        {
            ViewData["Message"] = "Your welcome message";

            return View();
        }
    }
}