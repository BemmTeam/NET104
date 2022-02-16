
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASMMAIN.Areas.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using ASMMAIN.Models;
namespace ASMMAIN.Areas.Controllers
{
    [Area("database")]
    public class DbManageController : Controller
    {

        private readonly ShopContext dbcontext;

        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<User> userManager ;
        private readonly SignInManager<User> signInManager; 

        public DbManageController(ShopContext dbcontext, RoleManager<IdentityRole> roleManager, UserManager<User> userManager, SignInManager<User> signInManager)
        {
            this.dbcontext = dbcontext;
            this.roleManager = roleManager;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [TempData]
        public string Message {get;set;}

        [TempData]
        public string MessageType {get; set;}

        [ViewData] 
        public int num {get;set;} = 0;
     

        [Route("/Dbmanage")]

        public IActionResult Index()
        {
            return View();
        }

        [Route("DbManage/createDB")]
        public async Task<IActionResult> CreateDB()
        {
            var success = await dbcontext.Database.EnsureCreatedAsync();
            var insert = new InsertData(dbcontext);

            if(success) { 
                Message = "Database đã tạo thành công có thể thêm dữ liệu mẫu" ; 
            }else { 
                MessageType = AlertModel.Type.error ; 
                Message = "không tạo được có thể database đã tồn tại";
            }
            return RedirectToAction(nameof(Index));
        }

        [Route("DbManage/insertDB")]
        public async Task<IActionResult> InserrtDB()
        {
            var insert = new InsertData(dbcontext);
            await insert.insertCategory();
            await insert.insertProduct();
            //   await insert.insertUser();

            // add role 
            var rolenames = typeof(RoleName).GetFields();
            foreach(var item in rolenames) { 
                string name = item.GetRawConstantValue().ToString(); 
                var ffound = await roleManager.FindByNameAsync(name); 
                if(ffound == null ) { 
                    await roleManager.CreateAsync(new IdentityRole(name));
                }
            }
            //tạo user admin : admin - admin123 
            var useradmin = await userManager.FindByEmailAsync("admin"); 
            if(useradmin  == null) { 
                useradmin = new User () { 
                    UserName = "Admin" , 
                    Email = "Admin@gmail.com" , 
                    
                    EmailConfirmed = true // không cần xác thực email nữa , 
                };
                await userManager.CreateAsync(useradmin,"admin123") ; 
                await userManager.AddToRoleAsync(useradmin , RoleName.Administrator) ; 
            }

            Message ="Đã Insert dữ liệu mẫu thành công !" ;

            return RedirectToAction(nameof(Index));
        }

        [Route("DbManage/deleteDB")]
        public async Task<IActionResult> DeleteDB()
        {
            await signInManager.SignOutAsync();
            var success = await dbcontext.Database.EnsureDeletedAsync();
            if(success) Message = "Xóa database thành công ! " ; 
            else { 
                MessageType = AlertModel.Type.error ; 
                Message = "Không xóa được Database" ;
            }
            return RedirectToAction(nameof(Index));
        }
    }
}