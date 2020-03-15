using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectAPI.Data;
using ProjectAPI.Data.Entities;

namespace FinalProjectV2.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SubCategoryItemsController : Controller
    {
        private readonly ProjectDbContext _context;

        public SubCategoryItemsController(ProjectDbContext context)
        {
            _context = context;
        }

        // GET: Admin/SubCategoryItems
        public async Task<IActionResult> Index()
        {
            var projectDbContext = _context.SubCategoryItems.Include(s => s.SubCategory);
            return View(await projectDbContext.ToListAsync());
        }

        // GET: Admin/SubCategoryItems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subCategoryItem = await _context.SubCategoryItems
                .Include(s => s.SubCategory)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subCategoryItem == null)
            {
                return NotFound();
            }

            return View(subCategoryItem);
        }

        // GET: Admin/SubCategoryItems/Create
        public IActionResult Create()
        {
            ViewData["SubCategoryId"] = new SelectList(_context.SubCategories, "Id", "Name");
            return View();
        }

        // POST: Admin/SubCategoryItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,PhotoPath,SubCategoryId")] SubCategoryItem subCategoryItem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(subCategoryItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SubCategoryId"] = new SelectList(_context.SubCategories, "Id", "Name", subCategoryItem.SubCategoryId);
            return View(subCategoryItem);
        }

        // GET: Admin/SubCategoryItems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subCategoryItem = await _context.SubCategoryItems.FindAsync(id);
            if (subCategoryItem == null)
            {
                return NotFound();
            }
            ViewData["SubCategoryId"] = new SelectList(_context.SubCategories, "Id", "Name", subCategoryItem.SubCategoryId);
            return View(subCategoryItem);
        }

        // POST: Admin/SubCategoryItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,PhotoPath,SubCategoryId")] SubCategoryItem subCategoryItem)
        {
            if (id != subCategoryItem.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(subCategoryItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SubCategoryItemExists(subCategoryItem.Id))
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
            ViewData["SubCategoryId"] = new SelectList(_context.SubCategories, "Id", "Name", subCategoryItem.SubCategoryId);
            return View(subCategoryItem);
        }

        // GET: Admin/SubCategoryItems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subCategoryItem = await _context.SubCategoryItems
                .Include(s => s.SubCategory)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subCategoryItem == null)
            {
                return NotFound();
            }

            return View(subCategoryItem);
        }

        // POST: Admin/SubCategoryItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var subCategoryItem = await _context.SubCategoryItems.FindAsync(id);
            _context.SubCategoryItems.Remove(subCategoryItem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SubCategoryItemExists(int id)
        {
            return _context.SubCategoryItems.Any(e => e.Id == id);
        }
    }
}
