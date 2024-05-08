﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pronia1.DataAccesLayer;

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

            return View(await _context.Categories.ToListAsync());
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