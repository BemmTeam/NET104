using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASMMAIN;
using ASMMAIN.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
namespace ASMMAIN.Areas.Controllers
{
    [Area("manage")]
    [Route("/manage/user/[action]")]
    [Authorize(Roles = RoleName.Administrator)]
    public class UserController : Controller
    {
        private readonly ShopContext _context;

        private readonly UserManager<User> userManager;

        private readonly SignInManager<User> signInManager; 
        
        private readonly RoleManager<IdentityRole> roleManager;

        public UserController(ShopContext context, UserManager<User> userManager, SignInManager<User> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
        }

        [ViewData]
        public int num {get; set;} = 1;

        [TempData] 
        public string Message {get;set;} 

        [TempData] 
        public string MessageType {get;set;}
        // GET: User
        [HttpGet("/manage/user/")]
        public async Task<IActionResult> Index()
        {
           
            return View(await _context.users.ToListAsync());
        }

        // GET: User/Details/5
        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.users
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: User/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        
    
        // POST: User/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HomeAddress,FullName,Id,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,PasswordHash,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount")] User user, string password)
        {
            if (ModelState.IsValid)
            {
             
                if(user.FullName == null || user.UserName ==null || user.Email == null) { 

                    Message = "Thiếu các trường dữ liệu !" ; 
                    MessageType = AlertModel.Type.success;
                    TempData.Peek("Message");
                    TempData.Peek("MessageType");
                    
                    return View(user) ;
                }
                var InUser = new User { FullName = user.FullName , UserName = user.UserName , HomeAddress = user.HomeAddress , Email = user.Email , EmailConfirmed = user.EmailConfirmed , PhoneNumber = user.PhoneNumber , PhoneNumberConfirmed = user.PhoneNumberConfirmed }; 

                var result = await userManager.CreateAsync(InUser,password);
                if(result.Succeeded){

                    Message = "Thêm User mới thành công";   
                    MessageType = AlertModel.Type.success;
                  return RedirectToAction(nameof(Index));

                }
                else { 
                    Message = result.ToString(); 
                    MessageType = AlertModel.Type.error;
                }

            }
            return View(user);
        }

        // GET: User/Edit/5
        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        // POST: User/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("HomeAddress,FullName,Id,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,PasswordHash,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount")] User user)
        {
            if (id != user.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // _context.Update(user);
                    // await _context.SaveChangesAsync();
                    var findUser = await userManager.FindByIdAsync(id);
                    findUser.HomeAddress = user.HomeAddress ; 
                    findUser.FullName = user.FullName; 
                    findUser.UserName = user.UserName;
                    findUser.Email = user.Email ; 
                    findUser.EmailConfirmed = user.EmailConfirmed ; 
                    findUser.PhoneNumber = user.PhoneNumber; 
                    findUser.PhoneNumberConfirmed = user.PhoneNumberConfirmed; 
                    await userManager.UpdateAsync(findUser);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: User/Delete/5
        [HttpGet]
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.users
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: User/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var user = await userManager.FindByIdAsync(id);
            var result =  await userManager.DeleteAsync(user);
            if(result.Succeeded) { 
                 Message = $"Xóa user {user.FullName} thành công"; 
            }
            else { 
                 Message = result.ToString(); 
                 MessageType = AlertModel.Type.error; 

            }
            return RedirectToAction(nameof(Index));

        }

        private bool UserExists(string id)
        {
            return _context.users.Any(e => e.Id == id);
        }
    }
}
