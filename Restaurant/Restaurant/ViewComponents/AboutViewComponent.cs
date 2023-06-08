using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Restaurant.DAL;
using Restaurant.Models;
using System.Threading.Tasks;

namespace Restaurant.ViewComponents
{
    public class AboutViewComponent : ViewComponent
    {
        private readonly AppDbContext _db;
        public AboutViewComponent(AppDbContext db)
        {
            _db=db;
        }
        #region InvokeAsync
        public async Task<IViewComponentResult> InvokeAsync()
        {
            About about = await _db.About.FirstOrDefaultAsync();
            return View(about);
        }
        #endregion
    }
}
