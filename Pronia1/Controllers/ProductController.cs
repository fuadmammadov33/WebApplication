﻿using Microsoft.AspNetCore.Mvc;

namespace Pronia1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Shop()
        {
            return View();
        }
    }
}
