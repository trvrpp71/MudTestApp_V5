using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MudTestApp.Data;
using MudTestApp.Models;

namespace MudTestApp.Controllers
{
    public class TestResultsController : Controller
    {
        private const string BindVariables = "TestResultsID,TestID,CompoundID,TestTemp,S1Thickness,S1Hardness_a,S1Hardness_b,S1WtAir_a,S1WtAir_b,S1WtWater_a,S1WtWater_b,S1_25Mod,S1_50Mod,S1_100Mod,S1_tensile,S1_elongation, ,S2Thickness,S2Hardness_a,S2Hardness_b,S2WtAir_a,S2WtAir_b,S2WtWater_a,S2WtWater_b,S2_25Mod,S2_50Mod,S2_100Mod,S2_tensile,S2_elongation,,S3Thickness,S3Hardness_a,S3Hardness_b,S3WtAir_a,S3WtAir_b,S3WtWater_a,S3WtWater_b,S3_25Mod,S3_50Mod,S3_100Mod,S3_tensile,S3_elongation";
        private readonly MudTestAppContext _context;

        public TestResultsController(MudTestAppContext context)
        {
            _context = context;
        }

        // GET: TestResults
        public async Task<IActionResult> Index()
        {
            var mudTestAppContext = _context.Results.Include(t => t.Compound).Include(t => t.Test);
            return View(await mudTestAppContext.ToListAsync());
        }

        // GET: TestResults/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testResults = await _context.Results
                .Include(t => t.Compound)
                .Include(t => t.Test)
                .FirstOrDefaultAsync(m => m.TestResultsID == id);
            if (testResults == null)
            {
                return NotFound();
            }

            return View(testResults);
        }

        // GET: TestResults/Create
        public IActionResult Create()
        {
            ViewData["CompoundID"] = new SelectList(_context.Compounds, "CompoundID", "CompoundName");
            ViewData["TestID"] = new SelectList(_context.Tests, "Customer", "Customer");
            return View();
        }

        // POST: TestResults/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind(BindVariables)] TestResults testResults)
        {
            if (ModelState.IsValid)
            {
                _context.Add(testResults);
                await _context.SaveChangesAsync();
                //return RedirectToAction(nameof(Index));

                return RedirectToAction("Details", "Tests", new { id = testResults.TestID });
            }
            ViewData["CompoundID"] = new SelectList(_context.Compounds, "CompoundID", "CompoundName", testResults.CompoundID);
            ViewData["TestID"] = new SelectList(_context.Tests, "Customer", "Customer", testResults.TestID);
            return View(testResults);
        }

        // GET: TestResults/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testResults = await _context.Results.FindAsync(id);
            if (testResults == null)
            {
                return NotFound();
            }
            ViewData["CompoundID"] = new SelectList(_context.Compounds, "CompoundID", "CompoundName", testResults.CompoundID);
            ViewData["TestID"] = new SelectList(_context.Tests, "Customer", "Customer", testResults.TestID);
            return View(testResults);
        }

        // POST: TestResults/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind(BindVariables)] TestResults testResults)
        {
            if (id != testResults.TestResultsID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(testResults);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TestResultsExists(testResults.TestResultsID))
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
            ViewData["CompoundID"] = new SelectList(_context.Compounds, "CompoundID", "CompoundName", testResults.CompoundID);
            ViewData["TestID"] = new SelectList(_context.Tests, "Customer", "Customer", testResults.TestID);
            return View(testResults);
        }

        // GET: TestResults/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testResults = await _context.Results
                .Include(t => t.Compound)
                .Include(t => t.Test)
                .FirstOrDefaultAsync(m => m.TestResultsID == id);
            if (testResults == null)
            {
                return NotFound();
            }

            return View(testResults);
        }

        // POST: TestResults/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var testResults = await _context.Results.FindAsync(id);
            _context.Results.Remove(testResults);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TestResultsExists(int id)
        {
            return _context.Results.Any(e => e.TestResultsID == id);
        }
    }
}
