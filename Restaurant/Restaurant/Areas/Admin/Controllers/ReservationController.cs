using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restaurant.DAL;
using Restaurant.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Restaurant.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class ReservationController : Controller
	{
		private readonly AppDbContext _db;
        public ReservationController(AppDbContext db)
        {
			_db = db;
        }
		#region Index
		public async Task<IActionResult> Index()
		{
			List<Reservation> reservations = await _db.Reservations.ToListAsync();
			return View(reservations);
		}
		#endregion
	}
}
