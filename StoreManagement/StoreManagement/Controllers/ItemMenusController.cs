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
    public class ItemMenusController : Controller
    {
        private readonly DataContext _context;

        public ItemMenusController(DataContext context)
        {
            _context = context;
        }

        // GET: ItemMenus
        public async Task<IActionResult> Index()
        {
            return View(await _context.ItemMenus.ToListAsync());
        }

        // GET: ItemMenus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemMenu = await _context.ItemMenus
                .FirstOrDefaultAsync(m => m.Id == id);
            if (itemMenu == null)
            {
                return NotFound();
            }

            return View(itemMenu);
        }

        // GET: ItemMenus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ItemMenus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MenuName,CategoryId,Price,CreateBy,UpdateBy,CreateDate,UpdateDate,Active")] ItemMenu itemMenu)
        {
            if (ModelState.IsValid)
            {
                _context.Add(itemMenu);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(itemMenu);
        }

        // GET: ItemMenus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemMenu = await _context.ItemMenus.FindAsync(id);
            if (itemMenu == null)
            {
                return NotFound();
            }
            return View(itemMenu);
        }

        // POST: ItemMenus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MenuName,CategoryId,Price,CreateBy,UpdateBy,CreateDate,UpdateDate,Active")] ItemMenu itemMenu)
        {
            if (id != itemMenu.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(itemMenu);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemMenuExists(itemMenu.Id))
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
            return View(itemMenu);
        }

        // GET: ItemMenus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemMenu = await _context.ItemMenus
                .FirstOrDefaultAsync(m => m.Id == id);
            if (itemMenu == null)
            {
                return NotFound();
            }

            return View(itemMenu);
        }

        // POST: ItemMenus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var itemMenu = await _context.ItemMenus.FindAsync(id);
            if (itemMenu != null)
            {
                _context.ItemMenus.Remove(itemMenu);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ItemMenuExists(int id)
        {
            return _context.ItemMenus.Any(e => e.Id == id);
        }
    }
}
