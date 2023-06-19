using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restaurant.DAL;
using Restaurant.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Restaurant.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin,ComManager")]
    [Area("Admin")]
	public class TestimonialsController : Controller
	{
		private readonly AppDbContext _db;
        public TestimonialsController(AppDbContext db)
        {
			_db = db;
        }
		#region Index
		public async Task<IActionResult> Index()
		{
			List<Testimonial> testimonials = await _db.Testimonials.ToListAsync();
			return View(testimonials);
		}
		#endregion

		#region Create
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]

		public async Task<IActionResult> Create(Testimonial testimonial)
		{
			await _db.Testimonials.AddAsync(testimonial);
			await _db.SaveChangesAsync();
			return RedirectToAction("Index");
		}
		#endregion

		#region Update
		public async Task<IActionResult> Update(int? id)
		{
			if (id == null)
				return NotFound();
			Testimonial dbt = await _db.Testimonials.FirstOrDefaultAsync(x => x.Id == id);
			if (dbt == null)
				return BadRequest();

			return View(dbt);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]

		public async Task<IActionResult> Update(int? id,Testimonial testimonial)
		{
			if (id == null)
				return NotFound();
			Testimonial dbt = await _db.Testimonials.FirstOrDefaultAsync(x => x.Id == id);
			if (dbt == null)
				return BadRequest();

			dbt.FullName = testimonial.FullName;
			dbt.Description = testimonial.Description;
			dbt.Role = testimonial.Role;

			await _db.SaveChangesAsync();
			return RedirectToAction("Index");
		}
		#endregion

		#region Detail
		public async Task<IActionResult> Detail(int? id)
		{
			if (id == null)
				return NotFound();
			Testimonial dbt = await _db.Testimonials.FirstOrDefaultAsync(x => x.Id == id);
			if (dbt == null)
				return BadRequest();

			return View(dbt);
		}
		#endregion

		#region Activity
		public async Task<IActionResult> Activity(int? id)
		{
			if (id == null)
				return NotFound();
			Testimonial dbt = await _db.Testimonials.FirstOrDefaultAsync(x => x.Id == id);
			if (dbt == null)
				return BadRequest();

			if (dbt.IsDeactive)
				dbt.IsDeactive = false;
			else
				dbt.IsDeactive = true;

			await _db.SaveChangesAsync();
			return RedirectToAction("Index");
		}
		#endregion
	}
}
