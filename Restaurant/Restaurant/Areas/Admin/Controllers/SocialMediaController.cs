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
	public class SocialMediaController : Controller
	{
		private readonly AppDbContext _db;
        public SocialMediaController(AppDbContext db)
        {
			_db = db;
        }
		#region Index
		public async Task<IActionResult> Index()
		{
			List<Social_Media> medias = await _db.SocialMedias.ToListAsync();
			return View(medias);
		}
		#endregion

		#region Update
		public async Task<IActionResult> Update(int? id)
		{
			if (id == null)
				return NotFound();
			Social_Media dbmedia = await _db.SocialMedias.FirstOrDefaultAsync(x => x.Id == id);
			if (dbmedia == null)
				return BadRequest();

			return View(dbmedia);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]

		public async Task<IActionResult> Update(int? id, Social_Media media)
		{
			if (id == null)
				return NotFound();
			Social_Media dbmedia = await _db.SocialMedias.FirstOrDefaultAsync(x => x.Id == id);
			if (dbmedia == null)
				return BadRequest();

			dbmedia.InstagramLink = media.InstagramLink;
			dbmedia.YoutbeLink = media.YoutbeLink;
			dbmedia.TwitterLink = media.TwitterLink;
			dbmedia.FaceeBookLink = media.FaceeBookLink;

			await _db.SaveChangesAsync();
			return RedirectToAction("Index");
		}
		#endregion
	}
}
