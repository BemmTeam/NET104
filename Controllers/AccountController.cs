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


                    var code = await userManager.GenerateEmailConfirmationTokenAsync(user); // phát sinh ra 1 mã token của user 
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code)); //encode ra url 
                    var callbackUrl = Url.ActionLink(
                        action: nameof(ConfirmEmail) , 
                        values: new {
                            userId = user.Id , 
                            code = code, 
                            returnUrl = returnUrl
                        }, protocol: Request.Scheme
                    );
                  await  emailSender.SendEmailAsync(model.Email , "Xác nhận tài khoản" ,
                   $"Bạn đã đăng ký tại shop lego nhấn vào link để xác nhận <a href='{callbackUrl}'>xác nhận</a>");

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
                // model.ErrorMessage = "Tên đăng nhập hoặc mật khẩu sai" ; 
                  Message =  new AlertModel(AlertModel.Type.error , "Tên đăng nhập hoặc mật khẩu không đúng");
              
              
                 
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

        // cấm truy cập 

        [HttpGet]
        public IActionResult AccessDenied(string returnUrl = null) { 

            returnUrl??= Url.Content("~/") ; 
            ViewData["returnUrl"] = returnUrl ; 
            return View();
        }
    }

    
}