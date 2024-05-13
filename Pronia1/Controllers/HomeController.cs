using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pronia1.DataAccesLayer;
using Pronia1.ViewModels.Categories;

namespace Pronia1.Controllers
{
    public class HomeController : Controller
    {
        private readonly Pronia1Context _context;
        public HomeController(Pronia1Context context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {

            var data = await _context.Categories
              .Where(x => x.isDeleted == false)
              .Select(x => new GetCategoryVM
              {
                  Id = x.Id,
                  Name = x.Name,
              })
              
             .ToListAsync();
             return View(data);
        }
        public async Task<IActionResult> Contact()
        {
            return View();
        }
        public async Task<IActionResult> About()
        {
            return View();
        }

        public async Task<IActionResult> Shop()
        {
            return View();
        }

        public async Task<IActionResult> Test(int? id)
        {
            if (id == null || id < 1) return BadRequest();
            var cat = await _context.Categories.FindAsync(id);
            _context.Categories.Remove(cat);
            await _context.SaveChangesAsync();
            return Content(cat.Name);
        }

    }
}
