using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MudTestApp.Data;
using MudTestApp.Models;

namespace MudTestApp.Controllers
{
    [Authorize(Roles = "Admin, Lab")]
    public class CompoundsController : Controller
    {
        private readonly MudTestAppContext _context;

        public CompoundsController(MudTestAppContext context)
        {
            _context = context;
        }

        // GET: Compounds
        public async Task<IActionResult> Index()
        {
            return View(await _context.Compounds.ToListAsync());
        }

        // GET: Compounds/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var compound = await _context.Compounds
                .FirstOrDefaultAsync(m => m.CompoundID == id);
            if (compound == null)
            {
                return NotFound();
            }

            return View(compound);
        }

        // GET: Compounds/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Compounds/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CompoundID,CompoundName,C_Hardness,C_25Mod,C_50Mod,C_100Mod,C_Tensile,C_Elongation,C_Production")] Compound compound)
        {
            if (ModelState.IsValid)
            {
                _context.Add(compound);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(compound);
        }

        // GET: Compounds/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var compound = await _context.Compounds.FindAsync(id);
            if (compound == null)
            {
                return NotFound();
            }
            return View(compound);
        }

        // POST: Compounds/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CompoundID,CompoundName,C_Hardness,C_25Mod,C_50Mod,C_100Mod,C_Tensile,C_Elongation,C_Production")] Compound compound)
        {
            if (id != compound.CompoundID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(compound);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompoundExists(compound.CompoundID))
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
            return View(compound);
        }

        // GET: Compounds/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var compound = await _context.Compounds
                .FirstOrDefaultAsync(m => m.CompoundID == id);
            if (compound == null)
            {
                return NotFound();
            }

            return View(compound);
        }

        // POST: Compounds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var compound = await _context.Compounds.FindAsync(id);
            _context.Compounds.Remove(compound);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompoundExists(int id)
        {
            return _context.Compounds.Any(e => e.CompoundID == id);
        }
    }
}
