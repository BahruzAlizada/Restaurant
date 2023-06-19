using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restaurant.DAL;
using Restaurant.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin,ComManager")]
    [Area("Admin")]
    public class PositionsController : Controller
    {
        private readonly AppDbContext _db;
        public PositionsController(AppDbContext db)
        {
            _db = db;
        }
        #region Index
        public async Task<IActionResult> Index()
        {
            List<Position> position = await _db.Positions.ToListAsync();
            return View(position);
        }
        #endregion

        #region Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(Position position)
        {
            await _db.Positions.AddAsync(position);
            await _db.SaveChangesAsync();  
            return RedirectToAction("Index");
        }
        #endregion

        #region Update
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
                return NotFound();
            Position dbposition = await _db.Positions.FirstOrDefaultAsync(x=> x.Id == id);
            if(dbposition == null)
                return BadRequest();

            return View(dbposition);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Update(int? id,Position position)
        {
            if (id == null)
                return NotFound();
            Position dbposition = await _db.Positions.FirstOrDefaultAsync(x => x.Id == id);
            if (dbposition == null)
                return BadRequest();

            dbposition.PositionName = position.PositionName;
            dbposition.Salary = position.Salary;

            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        #endregion
    }
}
