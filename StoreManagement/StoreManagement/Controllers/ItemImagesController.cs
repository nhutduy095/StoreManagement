using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StoreManagement.Data;
using StoreManagement.Models;

namespace StoreManagement.Controllers
{
    public class ItemImagesController : Controller
    {
        private readonly DataContext _context;

        public ItemImagesController(DataContext context)
        {
            _context = context;
        }

        // GET: ItemImages
        public async Task<IActionResult> Index()
        {
            return View(await _context.ItemImages.ToListAsync());
        }

        // GET: ItemImages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemImage = await _context.ItemImages
                .FirstOrDefaultAsync(m => m.ImageId == id);
            if (itemImage == null)
            {
                return NotFound();
            }

            return View(itemImage);
        }

        // GET: ItemImages/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ItemImages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ImageId,ImageURL,ImageBackground,ItemId,CreateBy,UpdateBy,CreateDate,UpdateDate,Active")] ItemImage itemImage)
        {
            if (ModelState.IsValid)
            {
                _context.Add(itemImage);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(itemImage);
        }

        // GET: ItemImages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemImage = await _context.ItemImages.FindAsync(id);
            if (itemImage == null)
            {
                return NotFound();
            }
            return View(itemImage);
        }

        // POST: ItemImages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ImageId,ImageURL,ImageBackground,ItemId,CreateBy,UpdateBy,CreateDate,UpdateDate,Active")] ItemImage itemImage)
        {
            if (id != itemImage.ImageId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(itemImage);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemImageExists(itemImage.ImageId))
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
            return View(itemImage);
        }

        // GET: ItemImages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemImage = await _context.ItemImages
                .FirstOrDefaultAsync(m => m.ImageId == id);
            if (itemImage == null)
            {
                return NotFound();
            }

            return View(itemImage);
        }

        // POST: ItemImages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var itemImage = await _context.ItemImages.FindAsync(id);
            if (itemImage != null)
            {
                _context.ItemImages.Remove(itemImage);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ItemImageExists(int id)
        {
            return _context.ItemImages.Any(e => e.ImageId == id);
        }
    }
}
