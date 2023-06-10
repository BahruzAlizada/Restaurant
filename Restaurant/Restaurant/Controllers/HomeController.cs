using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Restaurant.DAL;
using Restaurant.Models;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Restaurant.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;
        }

        #region Index
        public async Task<IActionResult> Index()
        {
            Slider slider = await _db.Slider.FirstOrDefaultAsync();
            return View(slider);
        }
        #endregion

        #region Error
        public IActionResult Error()
        {
            return View();
        }
        #endregion
    }
}
