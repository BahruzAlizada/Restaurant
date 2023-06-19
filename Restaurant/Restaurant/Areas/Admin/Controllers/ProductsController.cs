using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restaurant.DAL;
using Restaurant.Helpers;
using Restaurant.Models;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Threading.Tasks;

namespace Restaurant.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin,ComManager")]
    [Area("Admin")]
    public class ProductsController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _env;
        public ProductsController(AppDbContext db,IWebHostEnvironment env)
        {
            _env = env;
            _db = db;
        }
        #region Index
        public async Task<IActionResult> Index()
        {
            List<Product> products = await _db.Products.Include(x => x.Category).ToListAsync();
            return View(products);
        }
        #endregion

        #region Create
        public async Task<IActionResult> Create()
        {
            ViewBag.Categories = await _db.Categories.ToListAsync();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(Product product,int catId)
        {
            ViewBag.Categories = await _db.Categories.ToListAsync();

            #region Exist
            bool isExist = await _db.Products.AnyAsync(x=>x.Name == product.Name);
            if (isExist)
            {
                ModelState.AddModelError("Name", "This Product can not be null");
                return View();
            }
            #endregion

            #region Image
            if (product.Photo == null)
            {
                ModelState.AddModelError("Photo", "Photo can not be null");
                return View();
            }
            if (!product.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Select image type");
                return View();
            }
            if(product.Photo.IsOlder512Kb())
            {
                ModelState.AddModelError("Photo", "Max 512 Kb");
                return View();
            }
            string folder = Path.Combine(_env.WebRootPath, "img");
            product.Image = await product.Photo.SaveFileAsync(folder);
            #endregion

            product.CategoryId = catId;

            await _db.Products.AddAsync(product);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        #endregion

        #region Update
        public async Task<IActionResult> Update(int? id)
        {
            ViewBag.Categories = await _db.Categories.ToListAsync();

            if (id == null)
                return NotFound();
            Product dbproduct = await _db.Products.Include(x => x.Category).FirstOrDefaultAsync(x => x.Id == id);
            if (dbproduct == null)
                return BadRequest();

            return View(dbproduct);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Update(int? id,Product product,int catId)
        {
            ViewBag.Categories = await _db.Categories.ToListAsync();

            if (id == null)
                return NotFound();
            Product dbproduct = await _db.Products.Include(x => x.Category).FirstOrDefaultAsync(x => x.Id == id);
            if (dbproduct == null)
                return BadRequest();

            #region Exist
            bool isExist = await _db.Products.AnyAsync(x => x.Name == product.Name && x.Id!=product.Id);
            if (isExist)
            {
                ModelState.AddModelError("Name", "This Product can not be null");
                return View();
            }
            #endregion

            #region Image
            if (product.Photo != null)
            {
                if (!product.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Select image type");
                    return View();
                }
                if (product.Photo.IsOlder512Kb())
                {
                    ModelState.AddModelError("Photo", "Max 512 Kb");
                    return View();
                }
                string folder = Path.Combine(_env.WebRootPath, "img");
                product.Image = await product.Photo.SaveFileAsync(folder);
                string path = Path.Combine(_env.WebRootPath, dbproduct.Image);
                if (System.IO.File.Exists(path))
                    System.IO.File.Delete(path);
                dbproduct.Image = product.Image;     
            }
            #endregion

            dbproduct.CategoryId = catId;
            dbproduct.Name = product.Name;
            dbproduct.Description=product.Description;

            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        #endregion

        #region Detail
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
                return NotFound();
            Product dbproduct = await _db.Products.Include(x => x.Category).FirstOrDefaultAsync(x=>x.Id==id);
            if(dbproduct == null)
                return BadRequest();

            return View(dbproduct);
        }
        #endregion

        #region Activity
        public async Task<IActionResult> Activity(int? id)
        {
            if (id == null)
                return NotFound();
            Product dbproduct = await _db.Products.Include(x => x.Category).FirstOrDefaultAsync(x=>x.Id==id);
            if (dbproduct == null)
                return BadRequest();

            if(dbproduct.IsDeactive)
                dbproduct.IsDeactive = false;
            else
                dbproduct.IsDeactive = true;

            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        #endregion
    }
}
