using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Restaurant.DAL;
using Restaurant.Models;
using System.Threading.Tasks;

namespace Restaurant.ViewComponents
{
    public class ContactInfoViewComponent : ViewComponent
    {
        private readonly AppDbContext _db;
        public ContactInfoViewComponent(AppDbContext db)
        {
            _db = db;
        }
        #region InvokeAsync
        public async Task<IViewComponentResult> InvokeAsync()
        {
            ContactInfo info = await _db.ContactnInfo.FirstOrDefaultAsync();
            return View(info);
        }
        #endregion
    }
}
