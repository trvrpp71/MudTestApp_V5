using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MudTestApp.Data;
using MudTestApp.Models;
using MudTestApp.Models.TestViewModels;
using Microsoft.AspNetCore.Authorization;

namespace MudTestApp.Controllers
{
    [AllowAnonymous]
    public class ReportsController : Controller
    {
        private readonly MudTestAppContext _context;

        public ReportsController(MudTestAppContext context)
        {
            _context = context;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index(int? id)  //id = test ID
        {
            if (id == null)
            {
                return NotFound();
            }

            //tp modified code

            var viewModel = new ReportsViewModel();

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
    }
}
