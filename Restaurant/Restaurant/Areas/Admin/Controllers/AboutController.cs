using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restaurant.DAL;
using Restaurant.Helpers;
using Restaurant.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _env;
        public AboutController(AppDbContext db,IWebHostEnvironment env)
        {
            _env = env;
            _db = db;
        }
        #region Index
        public async Task<IActionResult> Index()
        {
            List<About> abouts = await _db.About.ToListAsync();
            return View(abouts);
        }
        #endregion

        #region Update
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
                return NotFound();
            About dbabout = await _db.About.FirstOrDefaultAsync(x=>x.Id == id);
            if (dbabout == null)
                return NotFound();

            return View(dbabout);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Update(int? id,About about)
        {
            if (id == null)
                return NotFound();
            About dbabout = await _db.About.FirstOrDefaultAsync(x => x.Id == id);
            if (dbabout == null)
                return NotFound();

            #region AboutImage1
            if (about.AboutPhoto1 != null)
            {
                if (!about.AboutPhoto1.IsImage())
                {
                    ModelState.AddModelError("Photo", "Select image type");
                    return View();
                }
                if (about.AboutPhoto1.IsOlder512Kb())
                {
                    ModelState.AddModelError("Photo", "Max 512Kb");
                    return View();
                }
                string folder = Path.Combine(_env.WebRootPath, "img");
                about.AboutImage1 = await about.AboutPhoto1.SaveFileAsync(folder);
                string path = Path.Combine(_env.WebRootPath, folder, dbabout.AboutImage1);
                if (System.IO.File.Exists(path))
                    System.IO.File.Delete(path);
                dbabout.AboutImage1  = about.AboutImage1;
            }
            #endregion

            #region AboutImage2
            if (about.AboutPhoto2 != null)
            {
                if (!about.AboutPhoto2.IsImage())
                {
                    ModelState.AddModelError("Photo", "Select image type");
                    return View();
                }
                if (about.AboutPhoto2.IsOlder512Kb())
                {
                    ModelState.AddModelError("Photo", "Max 512Kb");
                    return View();
                }
                string folder = Path.Combine(_env.WebRootPath, "img");
                about.AboutImage2 = await about.AboutPhoto2.SaveFileAsync(folder);
                string path = Path.Combine(_env.WebRootPath, folder, dbabout.AboutImage2);
                if (System.IO.File.Exists(path))
                    System.IO.File.Delete(path);
                dbabout.AboutImage2 = about.AboutImage2;
            }
            #endregion

            #region AboutImage3
            if (about.AboutPhoto3 != null)
            {
                if (!about.AboutPhoto3.IsImage())
                {
                    ModelState.AddModelError("Photo", "Select image type");
                    return View();
                }
                if (about.AboutPhoto3.IsOlder512Kb())
                {
                    ModelState.AddModelError("Photo", "Max 512Kb");
                    return View();
                }
                string folder = Path.Combine(_env.WebRootPath, "img");
                about.AboutImage3 = await about.AboutPhoto3.SaveFileAsync(folder);
                string path = Path.Combine(_env.WebRootPath, folder, dbabout.AboutImage3);
                if (System.IO.File.Exists(path))
                    System.IO.File.Delete(path);
                dbabout.AboutImage3 = about.AboutImage3;
            }
            #endregion

            #region AboutImage4
            if (about.AboutPhoto4 != null)
            {
                if (!about.AboutPhoto4.IsImage())
                {
                    ModelState.AddModelError("Photo", "Select image type");
                    return View();
                }
                if (about.AboutPhoto4.IsOlder512Kb())
                {
                    ModelState.AddModelError("Photo", "Max 512Kb");
                    return View();
                }
                string folder = Path.Combine(_env.WebRootPath, "img");
                about.AboutImage4 = await about.AboutPhoto4.SaveFileAsync(folder);
                string path = Path.Combine(_env.WebRootPath, folder, dbabout.AboutImage4);
                if (System.IO.File.Exists(path))
                    System.IO.File.Delete(path);
                dbabout.AboutImage4 = about.AboutImage4;
            }
            #endregion

            dbabout.Title = about.Title;
            dbabout.Description = about.Description;
            dbabout.PopularMasterChef = about.PopularMasterChef;
            dbabout.Experience = about.Experience;

            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        #endregion

        #region Detail
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
                return NotFound();
            About dbabout = await _db.About.FirstOrDefaultAsync(x => x.Id == id);
            if (dbabout == null)
                return NotFound();

            return View(dbabout);
        }
        #endregion
    }
}
