using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restaurant.DAL;
using Restaurant.Helpers;
using Restaurant.Models;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Restaurant.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChefsController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _env;
        public ChefsController(AppDbContext db,IWebHostEnvironment env)
        {
            _env = env;
            _db = db;
        }
        #region Index
        public async Task<IActionResult> Index()
        {
            List<Cheff> cheffs = await _db.Chefs.ToListAsync();
            return View(cheffs);
        }
        #endregion

        #region Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(Cheff cheff)
        {
            #region FullName
            if (cheff.FullName == null)
            {
                ModelState.AddModelError("FullName", "FullName can not be null");
                return View();
            }
            #endregion

            #region Image
            if (cheff.Photo == null)
            {
                ModelState.AddModelError("Photo", "Photo can not be null");
                return View();
            }
            if (!cheff.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Select image type");
                return View();
            }
            if (cheff.Photo.IsOlder512Kb())
            {
                ModelState.AddModelError("Photo", "Max 512 Kb");
                return View();
            }
            string folder = Path.Combine(_env.WebRootPath, "img");
            cheff.Image = await cheff.Photo.SaveFileAsync(folder);
            #endregion

            await _db.Chefs.AddAsync(cheff);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        #endregion

        #region Update
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
                return NotFound();
            Cheff dbcheff = await _db.Chefs.FirstOrDefaultAsync(x => x.Id == id);
            if (dbcheff == null)
                return BadRequest();

            return View(dbcheff);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Update(int? id,Cheff cheff)
        {
            if (id == null)
                return NotFound();
            Cheff dbcheff = await _db.Chefs.FirstOrDefaultAsync(x => x.Id == id);
            if (dbcheff == null)
                return BadRequest();

            #region FullName
            if (cheff.FullName==null)
            {
                ModelState.AddModelError("FullName", "Full Name can not be null");
                return View();
            }
            #endregion

            #region Image
            if (cheff.Photo != null)
            {
                if (!cheff.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Select image type");
                    return View();
                }
                if (cheff.Photo.IsOlder512Kb())
                {
                    ModelState.AddModelError("Photo", "Max 512Kb");
                    return View();
                }
                string folder = Path.Combine(_env.WebRootPath, "img");
                cheff.Image = await cheff.Photo.SaveFileAsync(folder);
                string path = Path.Combine(_env.WebRootPath, folder, dbcheff.Image);
                if (System.IO.File.Exists(path))
                    System.IO.File.Delete(path);
                dbcheff.Image = cheff.Image;
            }
            #endregion

            dbcheff.FullName = cheff.FullName;
            dbcheff.Role = cheff.Role;

            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        #endregion

        #region Activity
        public async Task<IActionResult> Activity(int? id)
        {
            if (id == null)
                return NotFound();
            Cheff dbcheff = await _db.Chefs.FirstOrDefaultAsync(x => x.Id == id);
            if (dbcheff == null)
                return BadRequest();

            if (dbcheff.IsDeactive)
                dbcheff.IsDeactive = false;
            else
                dbcheff.IsDeactive = true;

            await _db.SaveChangesAsync();
            return RedirectToAction("Index");

        }
        #endregion
    }
}
