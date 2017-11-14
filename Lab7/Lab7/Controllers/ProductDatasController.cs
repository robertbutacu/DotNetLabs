using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain;
using Persistence;

namespace Lab7.Controllers
{
    public class ProductDatasController : Controller
    {
        private readonly DatabaseContext _context;

        public ProductDatasController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: ProductDatas
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProductDatas.ToListAsync());
        }

        // GET: ProductDatas/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productData = await _context.ProductDatas
                .SingleOrDefaultAsync(m => m.Id == id);
            if (productData == null)
            {
                return NotFound();
            }

            return View(productData);
        }

        // GET: ProductDatas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProductDatas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Price,Date")] ProductData productData)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productData);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(productData);
        }

        // GET: ProductDatas/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productData = await _context.ProductDatas.SingleOrDefaultAsync(m => m.Id == id);
            if (productData == null)
            {
                return NotFound();
            }
            return View(productData);
        }

        // POST: ProductDatas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Name,Price,Date")] ProductData productData)
        {
            if (id != productData.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productData);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductDataExists(productData.Id))
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
            return View(productData);
        }

        // GET: ProductDatas/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productData = await _context.ProductDatas
                .SingleOrDefaultAsync(m => m.Id == id);
            if (productData == null)
            {
                return NotFound();
            }

            return View(productData);
        }

        // POST: ProductDatas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var productData = await _context.ProductDatas.SingleOrDefaultAsync(m => m.Id == id);
            _context.ProductDatas.Remove(productData);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductDataExists(Guid id)
        {
            return _context.ProductDatas.Any(e => e.Id == id);
        }
    }
}
