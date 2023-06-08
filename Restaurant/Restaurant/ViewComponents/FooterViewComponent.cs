using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Restaurant.DAL;
using Restaurant.ViewsModel;
using System.Threading.Tasks;

namespace Restaurant.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        private readonly AppDbContext _db;
        public FooterViewComponent(AppDbContext db)
        {
            _db = db;
        }

        #region InvokeAsync
        public async Task<IViewComponentResult> InvokeAsync()
        {
            FooterVM footerVM = new FooterVM
            {
                Bio = await _db.Bio.FirstOrDefaultAsync(),
                Social_Media=await _db.SocialMedias.FirstOrDefaultAsync()
            };

            return View(footerVM);
        }
        #endregion
    }
}
