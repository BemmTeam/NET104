using System;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ASMMAIN.Models { 


    [AllowAnonymous]
    public class SignUpModel{ 

        [Required(ErrorMessage = "Vui lòng nhập {0}")]
        [Display(Name = "Họ và Tên")]
        [StringLength(40, ErrorMessage = "{0} phải nhập từ {1} đến {2} kí tự" , MinimumLength = 3)]
        public string FullName {get;set;}

        [Required(ErrorMessage = "Vui lòng nhập {0}")]
        [Display(Name = "Username")]
        [StringLength(40, ErrorMessage = "{0} phải nhập từ {1} đến {2} kí tự" , MinimumLength = 3)]
        public string UserName {get;set;}

        
        [Required(ErrorMessage = "Vui lòng nhập {0}")]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Email không đúng định dạng")]
        public string Email {get;set;}

        [Required(ErrorMessage = "Vui lòng nhập {0}")]
        [StringLength(100, ErrorMessage = "{0} phải nhập từ {1} đến {2} kí tự", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Mật khẩu")]
        public string Password {get;set;}

        [Required(ErrorMessage = "Vui lòng nhập {0}")]
        [DataType(DataType.Password)]
        [Compare("Password" , ErrorMessage = "Mật khẩu không trùng nhau")]
        [Display(Name = "Nhập lại mật khẩu")]
        public string ConfirmPassword {get;set;}


        
        // public readonly UserManager<User> userManager; 
        // public readonly SignInManager<User> signInManager;

        // thong bao 
        public string ErrorMessage {get ; set;}


    }
}