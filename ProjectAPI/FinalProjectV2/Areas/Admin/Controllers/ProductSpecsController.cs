using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalProjectV2.Data.Entities;
using ProjectAPI.Data;

namespace FinalProjectV2.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductSpecsController : Controller
    {
        private readonly ProjectDbContext _context;

        public ProductSpecsController(ProjectDbContext context)
        {
            _context = context;
        }

        // GET: Admin/ProductSpecs
        public async Task<IActionResult> Index()
        {
            var projectDbContext = _context.ProductSpec.Include(p => p.Product).Include(p => p.Specification);
            return View(await projectDbContext.ToListAsync());
        }

        // GET: Admin/ProductSpecs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productSpec = await _context.ProductSpec
                .Include(p => p.Product)
                .Include(p => p.Specification)
                .FirstOrDefaultAsync(m => m.SpecificationId == id);
            if (productSpec == null)
            {
                return NotFound();
            }

            return View(productSpec);
        }

        // GET: Admin/ProductSpecs/Create
        public IActionResult Create()
        {
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Name");
            ViewData["SpecificationId"] = new SelectList(_context.Specification, "Id", "Name");
            return View();
        }

        // POST: Admin/ProductSpecs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Value,ProductId,SpecificationId")] ProductSpec productSpec)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productSpec);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Name", productSpec.ProductId);
            ViewData["SpecificationId"] = new SelectList(_context.Specification, "Id", "Name", productSpec.SpecificationId);
            return View(productSpec);
        }

        // GET: Admin/ProductSpecs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productSpec = await _context.ProductSpec.FindAsync(id);
            if (productSpec == null)
            {
                return NotFound();
            }
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Name", productSpec.ProductId);
            ViewData["SpecificationId"] = new SelectList(_context.Specification, "Id", "Name", productSpec.SpecificationId);
            return View(productSpec);
        }

        // POST: Admin/ProductSpecs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Value,ProductId,SpecificationId")] ProductSpec productSpec)
        {
            if (id != productSpec.SpecificationId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productSpec);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductSpecExists(productSpec.SpecificationId))
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
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Name", productSpec.ProductId);
            ViewData["SpecificationId"] = new SelectList(_context.Specification, "Id", "Name", productSpec.SpecificationId);
            return View(productSpec);
        }

        // GET: Admin/ProductSpecs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productSpec = await _context.ProductSpec
                .Include(p => p.Product)
                .Include(p => p.Specification)
                .FirstOrDefaultAsync(m => m.SpecificationId == id);
            if (productSpec == null)
            {
                return NotFound();
            }

            return View(productSpec);
        }

        // POST: Admin/ProductSpecs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productSpec = await _context.ProductSpec.FindAsync(id);
            _context.ProductSpec.Remove(productSpec);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductSpecExists(int id)
        {
            return _context.ProductSpec.Any(e => e.SpecificationId == id);
        }
    }
}
