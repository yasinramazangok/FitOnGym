using Microsoft.AspNetCore.Mvc;

namespace FitOnWebSite.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
