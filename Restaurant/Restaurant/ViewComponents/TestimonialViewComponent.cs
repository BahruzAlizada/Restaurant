using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Restaurant.DAL;
using Restaurant.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.ViewComponents
{
	public class TestimonialViewComponent : ViewComponent
	{
		private readonly AppDbContext _db;
        public TestimonialViewComponent(AppDbContext db)
        {
            _db = db;
        }

		#region InvokeAsync
		public async Task<IViewComponentResult> InvokeAsync()
		{
			List<Testimonial> testimonials = await _db.Testimonials.Where(x=>!x.IsDeactive).OrderByDescending(x => x.Id).Take(5).ToListAsync();
			return View(testimonials);
		}
		#endregion
	}
}
