
using System.ComponentModel.DataAnnotations;
namespace ASMMAIN.Models
{


    public class SignInModel
    {
        [Required(ErrorMessage = "Vui lòng nhập {0}")]
        [Display(Name = "Username")]
        [StringLength(40, ErrorMessage = "{0} phải nhập từ {1} đến {2} kí tự", MinimumLength = 3)]
        public string UserName { get; set; }


        [Required(ErrorMessage = "Vui lòng nhập {0}")]
        [StringLength(100, ErrorMessage = "{0} phải nhập từ {1} đến {2} kí tự", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Mật khẩu")]
        public string Password { get; set; }

        [Display(Name = "Ghi nhớ đăng nhập")]
        public bool rememberMe {get;set;}


        // thong bao 
        public string ErrorMessage {get ; set;}
    }
}