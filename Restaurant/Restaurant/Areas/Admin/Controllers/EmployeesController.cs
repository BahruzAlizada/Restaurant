using Microsoft.AspNetCore.Authorization;
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
    [Authorize(Roles ="Admin,ComManager")]
    public class EmployeesController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _env;
        public EmployeesController(AppDbContext db,IWebHostEnvironment env)
        {
            _env = env;
            _db = db;
        }

        #region Index
        public async Task<IActionResult> Index()
        {
            List<Employee> employees = await _db.Employees.Include(x => x.Position).ToListAsync();
            return View(employees);
        }
        #endregion

        #region Create
        public async Task<IActionResult> Create()
        {
            ViewBag.Positions = await _db.Positions.ToListAsync();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(Employee employee,int positionId)
        {
            ViewBag.Positions = await _db.Positions.ToListAsync();

            #region Image
            if (employee.Photo == null)
            {
                ModelState.AddModelError("Photo", "Photo can not be null");
                return View();
            }
            if (!employee.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Select image type");
                return View();
            }
            if (employee.Photo.IsOlder512Kb())
            {
                ModelState.AddModelError("Photo", "Max 512Kb");
                return View();
            }
            string folder = Path.Combine(_env.WebRootPath, "img");
            employee.Image = await employee.Photo.SaveFileAsync(folder);
            #endregion

            employee.PositionId=positionId;
            await _db.Employees.AddAsync(employee);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        #endregion

        #region Update
        public async Task<IActionResult> Update(int? id)
        {
            ViewBag.Positions = await _db.Positions.ToListAsync();

            if (id == null)
                return NotFound();
            Employee dbemployee = await _db.Employees.FirstOrDefaultAsync(x => x.Id == id);
            if (dbemployee == null)
                return BadRequest();

            return View(dbemployee);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Update(int? id,Employee employee,int positionId)
        {
            ViewBag.Positions = await _db.Positions.ToListAsync();

            if (id == null)
                return NotFound();
            Employee dbemployee = await _db.Employees.FirstOrDefaultAsync(x => x.Id == id);
            if (dbemployee == null)
                return BadRequest();

            #region Image
            if(employee.Photo != null)
            {
                if (!employee.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Select image type");
                    return View();
                }
                if (employee.Photo.IsOlder512Kb())
                {
                    ModelState.AddModelError("Photo", "Max 512Kb");
                    return View();
                }
                string folder = Path.Combine(_env.WebRootPath, "img");
                employee.Image = await employee.Photo.SaveFileAsync(folder);
                string path = Path.Combine(_env.WebRootPath, folder ,dbemployee.Image);
                if (System.IO.File.Exists(path))
                    System.IO.File.Delete(path);
                dbemployee.Image = employee.Image;
            }
            #endregion

            dbemployee.FullName=employee.FullName;
            dbemployee.Email = employee.Email;
            dbemployee.PositionId = positionId;

            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        #endregion

        #region Delete
        public IActionResult Delete(int? id)
        {
            if (id == null)
                return NotFound();
            Employee dbemployee = _db.Employees.FirstOrDefault(x => x.Id == id);
            if (dbemployee == null)
                return BadRequest();

            return View(dbemployee);
        }

        [ActionName("Delete")]
        [HttpPost]
        [ValidateAntiForgeryToken]

       public IActionResult DeletePost(int? id)
        {
            if (id == null)
                return NotFound();
            Employee dbemployee =  _db.Employees.FirstOrDefault(x => x.Id == id);
            if (dbemployee == null)
                return BadRequest();

            _db.Remove(dbemployee);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        #endregion
    }
}
