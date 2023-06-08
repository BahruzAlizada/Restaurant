using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restaurant.DAL;
using Restaurant.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.ViewComponents
{
    public class ServiceViewComponent : ViewComponent
    {
        private readonly AppDbContext _db;
        public ServiceViewComponent(AppDbContext db)
        {
            _db = db;
        }

        #region Invoke
        public async Task<IViewComponentResult> InvokeAsync()
        {       
            List<Service> services = await _db.Services.OrderByDescending(x => x.Id).Take(4).ToListAsync();
            return View(services);
        }
        #endregion
    }
}
