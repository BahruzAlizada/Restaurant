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
    public class ChefViewComponent : ViewComponent
    {
        private readonly AppDbContext _db;
        public ChefViewComponent(AppDbContext db)
        {
            _db = db;
        }

        #region InvokeAsync
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Employee> employees = await _db.Employees.Where(x=>x.PositionId==6 || x.PositionId==7)
                                        .Include(x=>x.Position).Take(4).ToListAsync();
            return View(employees);
        }
        #endregion
    }
}
