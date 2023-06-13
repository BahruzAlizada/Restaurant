using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restaurant.DAL;
using Restaurant.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Restaurant.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServicesController : Controller
    {
        private readonly AppDbContext _db;
        public ServicesController(AppDbContext db)
        {
            _db = db;
        }
        #region Index
        public async Task<IActionResult> Index()
        {
            List<Service> services = await _db.Services.ToListAsync();
            return View(services);
        }
        #endregion

        #region Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(Service service)
        {
            #region IsExist
            bool isExist = await _db.Services.AnyAsync(x => x.Title == service.Title);
            if (isExist)
            {
                ModelState.AddModelError("Title", "This service already is Exist!");
                return View();
            }
            #endregion

            #region Icon
            if (service.Icon == null)
            {
                ModelState.AddModelError("Icon", "Icon can not be null");
                return View();
            }
            #endregion

            await _db.Services.AddAsync(service);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        #endregion

        #region Update
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
                return NotFound();
            Service dbservice = await _db.Services.FirstOrDefaultAsync(x => x.Id == id);
            if (dbservice == null)
                return BadRequest();

            return View(dbservice);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Update(int? id,Service service)
        {
            if (id == null)
                return NotFound();
            Service dbservice = await _db.Services.FirstOrDefaultAsync(x => x.Id == id);
            if (dbservice == null)
                return BadRequest();

            #region IsExist
            bool isExist = await _db.Services.AnyAsync(x => x.Title == service.Title && x.Id!=id);
            if (isExist)
            {
                ModelState.AddModelError("Title", "This service already is Exist!");
                return View();
            }
            #endregion

            dbservice.Icon = service.Icon;
            dbservice.Title = service.Title;
            dbservice.Description = service.Description;

            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        #endregion

        #region Detail
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
                return NotFound();
            Service dbservice = await _db.Services.FirstOrDefaultAsync(x => x.Id == id);
            if (dbservice == null)
                return BadRequest();

            return View(dbservice);
        }
        #endregion

        #region Activity
        public async Task<IActionResult> Activity(int? id)
        {
            if (id == null)
                return NotFound();
            Service dbservice = await _db.Services.FirstOrDefaultAsync(x => x.Id == id);
            if (dbservice == null)
                return BadRequest();

            if (dbservice.IsDeactive)
                dbservice.IsDeactive = false;
            else
                dbservice.IsDeactive = true;

            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        #endregion
    }
}
