using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restaurant.DAL;
using Restaurant.Models;
using System.Threading.Tasks;

namespace Restaurant.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly AppDbContext _db;
        public HeaderViewComponent(AppDbContext db)
        {
            _db = db;
        }

        #region InvokeAsync
        public async Task<IViewComponentResult> InvokeAsync()
        {
            Bio bio = await _db.Bio.FirstOrDefaultAsync();
            return View(bio);
        }
        #endregion
    }
}
