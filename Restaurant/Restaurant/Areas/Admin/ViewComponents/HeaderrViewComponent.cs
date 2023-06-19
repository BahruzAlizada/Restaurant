using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Restaurant.DAL;
using Restaurant.Models;
using Restaurant.ViewsModel;
using System.Threading.Tasks;

namespace Restaurant.Areas.Admin.ViewComponents
{
    public class HeaderrViewComponent : ViewComponent
    {
        private UserManager<AppUser> _userManager;
        private readonly AppDbContext _db;
        public HeaderrViewComponent(UserManager<AppUser> userManager,AppDbContext db)
        {
            _db = db;
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
          
            ProfileHeadVM headVM = new ProfileHeadVM
            {
                Username = user.UserName,
                Image = user.Image
            };
            return View(headVM);
        }
    }
}
