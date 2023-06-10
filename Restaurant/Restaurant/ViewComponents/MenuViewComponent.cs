using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restaurant.DAL;
using Restaurant.ViewsModel;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        private readonly AppDbContext _db;
        public MenuViewComponent(AppDbContext db)
        {
            _db = db;
        }
        #region InvokeAsync
        public async Task<IViewComponentResult> InvokeAsync()
        {
            MenuVM menu = new MenuVM
            {
                Category = await _db.Categories.ToListAsync(),
                Products = await _db.Products.Where(x => !x.IsDeactive).ToListAsync(),
            };

            return View(menu);
        }
        #endregion
    }
}
