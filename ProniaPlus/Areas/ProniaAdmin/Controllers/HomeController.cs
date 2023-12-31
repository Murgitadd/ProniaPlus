﻿using ProniaPlus.DAL;
using Microsoft.AspNetCore.Mvc;

namespace ProniaPlus.Areas.Admin.Controllers
{
    [Area("ProniaAdmin")]
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
