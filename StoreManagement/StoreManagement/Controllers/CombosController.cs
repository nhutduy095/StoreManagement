﻿using System;
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
    public class CombosController : Controller
    {
        private readonly DataContext _context;

        public CombosController(DataContext context)
        {
            _context = context;
        }

        // GET: Combos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Combos.ToListAsync());
        }

        // GET: Combos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var combos = await _context.Combos
                .FirstOrDefaultAsync(m => m.ComboId == id);
            if (combos == null)
            {
                return NotFound();
            }

            return View(combos);
        }

        // GET: Combos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Combos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ComboId,ComboName,Description,Price,CreateBy,UpdateBy,CreateDate,UpdateDate,Active")] Combos combos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(combos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(combos);
        }

        // GET: Combos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var combos = await _context.Combos.FindAsync(id);
            if (combos == null)
            {
                return NotFound();
            }
            return View(combos);
        }

        // POST: Combos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ComboId,ComboName,Description,Price,CreateBy,UpdateBy,CreateDate,UpdateDate,Active")] Combos combos)
        {
            if (id != combos.ComboId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(combos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CombosExists(combos.ComboId))
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
            return View(combos);
        }

        // GET: Combos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var combos = await _context.Combos
                .FirstOrDefaultAsync(m => m.ComboId == id);
            if (combos == null)
            {
                return NotFound();
            }

            return View(combos);
        }

        // POST: Combos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var combos = await _context.Combos.FindAsync(id);
            if (combos != null)
            {
                _context.Combos.Remove(combos);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CombosExists(int id)
        {
            return _context.Combos.Any(e => e.ComboId == id);
        }
    }
}
