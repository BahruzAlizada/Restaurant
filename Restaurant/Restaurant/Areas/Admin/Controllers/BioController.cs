using Microsoft.AspNetCore.Mvc;

namespace Restaurant.Areas.Admin.Controllers
{
    public class BioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
