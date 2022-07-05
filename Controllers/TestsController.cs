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
using MudTestApp.Models.TestViewModels;

namespace MudTestApp.Controllers
{

    public class TestsController : Controller
    {
        private readonly MudTestAppContext _context;

        public TestsController(MudTestAppContext context)
        {
            _context = context;
        }

        // GET: Tests
        [AllowAnonymous]
        public async Task<IActionResult> Index( )
        {

            var testIndexData = from t in _context.Tests
                            join c in _context.Customers on t.CustomerID equals c.CustomerID into t2
                            from c in t2.DefaultIfEmpty()
                            select new TestIndexViewModel { TestVm = t, CustomerVm = c };
            return View(testIndexData);


        }

        // GET: Tests/Details/5

        public async Task<IActionResult> Details(int? id, int? CustomerID, int? CompoundId, int? TestResultsID)  //id = test ID
        {
            if (id == null)
            {
                return NotFound();
            }

            //tp modified code

            var viewModel = new TestDetailViewModel();

            viewModel.TestDVm = await _context.Tests
                .Include(i => i.Customer)
                .Include(i => i.Results)
                    .ThenInclude(i => i.Compound)
                .FirstOrDefaultAsync(t => t.TestID == id);

            if (viewModel == null)
            {
                return NotFound();
            }

            return View(viewModel);
        }

        // GET: Tests/Create
    
        public IActionResult Create()
        {
            ViewData["CustomerID"] = new SelectList(_context.Customers, "CustomerID", "CompanyName");

        
            return View();
        }

        // POST: Tests/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(

            [Bind("Epicor,CustomerID, LabTechAssigned,MudType,MudSystemName,ReceivedDate,ExposureTime,DateStarted,DateEnded,TimeOut,TestComments")] Test test)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    var errors = ModelState.SelectMany(x => x.Value.Errors.Select(z => z.Exception));
                }


                if (ModelState.IsValid)
                {
                    _context.Add(test);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }

            }
            catch (DbUpdateException /* ex */)
            {
                //log the error (uncomments the ex variable and write a log
                ModelState.AddModelError("", "Unable to save changes. " + "Try again and if problem persists, " + "see your system admin.");
            }

            return View(test);
        }

        // GET: Tests/Edit/5

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var test = await _context.Tests.FindAsync(id);
            if (test == null)
            {
                return NotFound();
            }

            ViewData["CustomerID"] = new SelectList(_context.Customers, "CustomerID", "CompanyName", test.CustomerID);

            return View(test);
        }

        // POST: Tests/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TestID,Epicor,CustomerID,LabTechAssigned,MudType,MudSystemName,ReceivedDate,ExposureTime,DateStarted,DateEnded,TimeOut,TestComments")] Test test)


        {
            if (id != test.TestID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(test);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TestExists(test.TestID))
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
            return View(test);
        }

        // GET: Tests/Delete/5
        public async Task<IActionResult> Delete(int? id, bool? saveChangesError= false)
        {
            if (id == null)
            {
                return NotFound();
            }

            var test = await _context.Tests
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.TestID == id);
            if (test == null)
            {
                return NotFound();
            }

            if (saveChangesError.GetValueOrDefault())
            {
                ViewData["ErrorMessage"] = "Delete failed. Please try again. If problem persists, please see system Admin.";
            }

            return View(test);
        }

        // POST: Tests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var test = await _context.Tests.FindAsync(id);

            if(test == null)
            {
                return RedirectToAction(nameof(Index));
            }
            try
            {
                _context.Tests.Remove(test);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateException /* ex */)
            {
                //log the error
                return RedirectToAction(nameof(Delete), new { id = id, saveChangesError = true });
            }

        }

        private bool TestExists(int id)
        {
            return _context.Tests.Any(e => e.TestID == id);
        }
    }
}
