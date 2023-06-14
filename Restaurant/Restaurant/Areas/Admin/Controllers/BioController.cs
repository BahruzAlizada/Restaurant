using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restaurant.DAL;
using Restaurant.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Restaurant.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BioController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _env;
        public BioController(AppDbContext db,IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }
        #region Index
        public async Task<IActionResult> Index()
        {
            List<Bio> bio = await _db.Bio.ToListAsync();
            return View(bio);
        }
        #endregion

        #region Update
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
                return NotFound();
            Bio dbbio = await _db.Bio.FirstOrDefaultAsync(x => x.Id == id);
            if (dbbio == null)
                return BadRequest();

            return View(dbbio);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Update(int? id, Bio bio)
        {
            if (id == null)
                return NotFound();
            Bio dbbio = await _db.Bio.FirstOrDefaultAsync(x => x.Id == id);
            if (dbbio == null)
                return BadRequest();

            dbbio.Header = bio.Header;
            dbbio.FooterPhone = bio.FooterPhone;
            dbbio.FooterAddress = bio.FooterAddress;
            dbbio.FooterEmail = bio.FooterEmail;
            dbbio.OpenTime = bio.OpenTime;
            dbbio.CloseTime=bio.CloseTime;

            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        #endregion
    }
}
