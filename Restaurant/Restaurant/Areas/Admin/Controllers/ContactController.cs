using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restaurant.DAL;
using Restaurant.Models;
using Restaurant.ViewsModel;
using System;
using System.Threading.Tasks;

namespace Restaurant.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactController : Controller
    {
        private readonly AppDbContext _db;
        public ContactController(AppDbContext db)
        {
            _db = db;
        }
        #region Index
        public async Task<IActionResult> Index()
        {
            ContactVM contact = new ContactVM
            {
                ContactInfo  = await _db.ContactnInfo.ToListAsync(),
                Form = await _db.ContactForms.ToListAsync(),
            };
            return View(contact);
        }
        #endregion

        #region Update
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
                return NotFound();
            ContactInfo dbinfo = await _db.ContactnInfo.FirstOrDefaultAsync();
            if (dbinfo == null)
                return BadRequest();

            return View(dbinfo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Update(int? id,ContactInfo info)
        {
            if (id == null)
                return NotFound();
            ContactInfo dbinfo = await _db.ContactnInfo.FirstOrDefaultAsync();
            if (dbinfo == null)
                return BadRequest();

            dbinfo.TechinialEmail = info.TechinialEmail;
            dbinfo.GeneralEmail= info.GeneralEmail;
            dbinfo.BookingEmail= info.BookingEmail;

            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        #endregion
    }
}
