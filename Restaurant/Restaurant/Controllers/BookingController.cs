using Microsoft.AspNetCore.Mvc;
using Restaurant.DAL;
using Restaurant.Models;
using System.Threading.Tasks;

namespace Restaurant.Controllers
{
    public class BookingController : Controller
    {
        private readonly AppDbContext _db;
        public BookingController(AppDbContext db)
        {
            _db = db;
        }
        #region Index
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Index(Reservation reservation)
        {
            await _db.Reservations.AddAsync(reservation);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        #endregion

    }
}
