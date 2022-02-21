using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASMMAIN;
using ASMMAIN.Models;

namespace ASMMAIN.Areas.Controllers
{
    [Area("manage")]

    [Route("/manage/cart/[action]")]
    public class CartController : Controller
    {
        private readonly ShopContext _context;
        
        [ViewData]
        public int num {get;set;} =4 ; 
        public CartController(ShopContext context)
        {
            _context = context;
        }

        // GET: Cart
        [HttpGet]
        [Route("/manage/cart")]

        public async Task<IActionResult> Index()
        {
            var shopContext = _context.carts.Include(c => c.user);
            return View(await shopContext.ToListAsync());
        }

        // GET: Cart/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cart = await _context.carts
                .Include(c => c.user)
                .FirstOrDefaultAsync(m => m.cart_id == id);
            if (cart == null)
            {
                return NotFound();
            }

            return View(cart);
        }

        // GET: Cart/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.users, "Id", "Id");
            return View();
        }

        // POST: Cart/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("cart_id,created_date,status,UserId,productList,total")] Cart cart)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cart);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.users, "Id", "Id", cart.UserId);
            return View(cart);
        }

        // GET: Cart/Edit/5
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cart = await _context.carts.FindAsync(id);
            
            if (cart == null)
            {
                return NotFound();
            }

            ViewData["UserId"] = new SelectList(_context.users, "Id", "Id", cart.UserId);
            return View(cart);
        }

        // POST: Cart/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Cart cart)
        {
            
            if (id != cart.cart_id)
            {
                return NotFound();

            }

            if (ModelState.IsValid)
            {
                try
                {

                    _context.Update(cart);
                    await _context.SaveChangesAsync();

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CartExists(cart.cart_id))
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
                    Console.WriteLine($"khong vao dcaa");

            ViewData["UserId"] = new SelectList(_context.users, "Id", "Id", cart.UserId);
            return View(cart);
        }

        // GET: Cart/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cart = await _context.carts
                .Include(c => c.user)
                .FirstOrDefaultAsync(m => m.cart_id == id);
            if (cart == null)
            {
                return NotFound();
            }

            return View(cart);
        }

        // POST: Cart/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cart = await _context.carts.FindAsync(id);
            _context.carts.Remove(cart);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CartExists(int id)
        {
            return _context.carts.Any(e => e.cart_id == id);
        }
    }
}
