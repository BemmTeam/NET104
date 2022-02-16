using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASMMAIN;
using ASMMAIN.Models;
using Microsoft.AspNetCore.Authorization ; 
using Microsoft.AspNetCore.Identity;
namespace ASMMAIN.Areas.Controllers
{
    [Area("manage")]
    [Authorize(Roles = RoleName.Administrator)]
    public class ProductController : Controller
    {
        private readonly ShopContext _context;

        [ViewData] 
        public int num {get; set;} = 2 ;
        public ProductController(ShopContext context)
        {
            _context = context;
        }

        // GET: Product
        [HttpGet("/manage/product")]
        public async Task<IActionResult> Index()
        {
            var shopContext = _context.products.Include(p => p.category);
            return View(await shopContext.ToListAsync());
        }

        // GET: Product/Details/5
        [HttpGet("/manage/product/details/{id?}")]

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.products
                .Include(p => p.category)
                .FirstOrDefaultAsync(m => m.product_id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Product/Create
        [HttpGet("/manage/product/create/")]

        public IActionResult Create()
        {
            ViewData["category_id"] = new SelectList(_context.categories, "category_id", "name");
            return View();
        }

        // POST: Product/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost("/manage/product/create/")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("product_id,name,price,quantity,description,image_url,category_id")] Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["category_id"] = new SelectList(_context.categories, "category_id", "name", product.category_id);
            return View(product);
        }

        // GET: Product/Edit/5
        [HttpGet("/manage/product/edit/{id?}")]

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["category_id"] = new SelectList(_context.categories, "category_id", "name", product.category_id);
            return View(product);
        }

        // POST: Product/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost("/manage/product/edit/{id?}") , ActionName("edit")]
        
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("product_id,name,price,quantity,description,image_url,category_id")] Product product)
        {
            if (id != product.product_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.product_id))
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
            ViewData["category_id"] = new SelectList(_context.categories, "category_id", "name", product.category_id);
            return View(product);
        }

        // GET: Product/Delete/5
        [HttpGet("/manage/product/delete/{id?}")]

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.products
                .Include(p => p.category)
                .FirstOrDefaultAsync(m => m.product_id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Product/Delete/5
        [HttpPost("/manage/product/delete/{id?}"), ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.products.FindAsync(id);
            _context.products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.products.Any(e => e.product_id == id);
        }
    }
}
