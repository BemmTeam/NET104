namespace ASMMAIN.Controllers
{
    using System;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Routing.Constraints;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Authorization;
    using System.Threading.Tasks;
    using ASMMAIN.Models;
    using Microsoft.Extensions.Logging;
    using Microsoft.AspNetCore.WebUtilities;
    using System.Text;
    using ASMMAIN.Services;
    using Microsoft.AspNetCore.Identity.UI.Services;

    [Authorize]
    [Route("/Account/[action]")]
    public class AccountController : Controller
    {

        private readonly SignInManager<User> signInManager;

        private readonly UserManager<User> userManager;

        private readonly IEmailSender emailSender ; 


        public AccountController(SignInManager<User> signInManager, UserManager<User> userManager, IEmailSender emailSender)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.emailSender = emailSender;
        }


        [ViewData]
        public AlertModel Message {get; set;}

        // Account/signup 
        [HttpGet]
        [AllowAnonymous]
        public IActionResult signup(string returnUrl = null)
        {
            returnUrl ??= Url.Content("/");
            ViewData["ReturnUrl"] = returnUrl;
                 
            if(signInManager.IsSignedIn(User)) { 
                return LocalRedirect(returnUrl);
            }
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> signup(SignUpModel model, string returnUrl = null)
        {
            returnUrl ??= Url.Content("/");
            ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid)
            {

                User user = new User { FullName = model.FullName ,  UserName = model.UserName, Email = model.Email };
                var result = await userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {


                    var code = await userManager.GenerateEmailConfirmationTokenAsync(user); // ph??t sinh ra 1 m?? token c???a user 
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code)); //encode ra url 
                    var callbackUrl = Url.ActionLink(
                        action: nameof(ConfirmEmail) , 
                        values: new {
                            userId = user.Id , 
                            code = code, 
                            returnUrl = returnUrl
                        }, protocol: Request.Scheme
                    );
                  await  emailSender.SendEmailAsync(model.Email , "X??c nh???n t??i kho???n" ,
                   $"B???n ???? ????ng k?? t???i shop lego nh???n v??o link ????? x??c nh???n <a href='{callbackUrl}'>x??c nh???n</a>");

                    return View("notifyEmail");
                }
                else
                {
                    model.ErrorMessage = result.ToString();
                    return View(model);

                }
            }
            return View(model);
        }

        // Account/SignIn

        [HttpGet]
        [AllowAnonymous]
        public IActionResult SignIn(string returnUrl = null){
            
            returnUrl ??= Url.Content("~/");
            ViewData["ReturnUrl"] = returnUrl;
             
            if(signInManager.IsSignedIn(User)) { 
                return LocalRedirect(returnUrl);
            }
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> SignIn(SignInModel model , string returnUrl = null){
            
            returnUrl ??= Url.Content("~/");
            ViewData["ReturnUrl"] = returnUrl ; 
            if(ModelState.IsValid) { 
           
                
            var result = await signInManager.PasswordSignInAsync(model.UserName , model.Password,model.rememberMe, lockoutOnFailure:true);

            if(result.Succeeded) { 
                
                // dang nhap thanh cong !
                return LocalRedirect(returnUrl);
            }
            else { 
                // model.ErrorMessage = "T??n ????ng nh???p ho???c m???t kh???u sai" ; 
                  Message =  new AlertModel(AlertModel.Type.error , "T??n ????ng nh???p ho???c m???t kh???u kh??ng ????ng");
              
              
                 
                return View(model);
            }
            
            }
            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> ConfirmEmail(string userId, string code)
        {
            if (userId == null || code == null)
            {
                 return View("ErrorConfirmEmail");
               
            }
            var user = await userManager.FindByIdAsync(userId);
            if (user == null)
            {

                 return View("ErrorConfirmEmail");
            }
            code = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(code));
            var result = await userManager.ConfirmEmailAsync(user, code);
            if(result.Succeeded) { 
                await signInManager.SignInAsync(user, isPersistent: false);
            }
            return View(result.Succeeded ? "ConfirmEmail" : "ErrorConfirmEmail");
         
        }

        //dang xuat 

        [HttpGet] 
        
        public async Task<IActionResult> Signout(string returnUrl = null) { 
            await  signInManager.SignOutAsync();
            returnUrl??= Url.Content("~/");
            return LocalRedirect(returnUrl);
        }

        // c???m truy c???p 

        [HttpGet]
        public IActionResult AccessDenied(string returnUrl = null) { 

            returnUrl??= Url.Content("~/") ; 
            ViewData["returnUrl"] = returnUrl ; 
            return View();
        }
    }

    
}