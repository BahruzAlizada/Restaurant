using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restaurant.DAL;
using Restaurant.Helpers;
using Restaurant.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Restaurant.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _env;
        public SliderController(AppDbContext db,IWebHostEnvironment env)
        {
            _env = env;
            _db = db;
        }
        #region Index
        public async Task<IActionResult> Index()
        {
            List<Slider> slider = await _db.Slider.ToListAsync();
            return View(slider);
        }
        #endregion

        #region Update
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
                return NotFound();
            Slider dbslider = await _db.Slider.FirstOrDefaultAsync(x => x.Id == id);
            if (dbslider == null)
                return BadRequest();

            return View(dbslider);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Update(int? id,Slider slider)
        {
            if (id == null)
                return NotFound();
            Slider dbslider = await _db.Slider.FirstOrDefaultAsync(x => x.Id == id);
            if (dbslider == null)
                return BadRequest();

            #region Image
            if (slider.Photo != null)
            {
                if (!slider.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Select image type");
                    return View();
                }
                if (slider.Photo.IsOlder512Kb())
                {
                    ModelState.AddModelError("Photo", "Max 512Kb");
                    return View();
                }
                string folder = Path.Combine(_env.WebRootPath, "img");
                slider.Image = await slider.Photo.SaveFileAsync(folder);
                string path = Path.Combine(_env.WebRootPath, folder, dbslider.Image);
                if (System.IO.File.Exists(path))
                    System.IO.File.Delete(path);
                dbslider.Image = slider.Image;
            }
            #endregion

            dbslider.Title = slider.Title;
            dbslider.Description = slider.Description;

            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        #endregion

        #region Detail
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
                return NotFound();
            Slider dbslider = await _db.Slider.FirstOrDefaultAsync(x => x.Id == id);
            if (dbslider == null)
                return BadRequest();

            return View(dbslider);
        }
        #endregion
    }
}
