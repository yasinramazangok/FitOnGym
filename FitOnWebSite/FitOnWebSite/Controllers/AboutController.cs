using Microsoft.AspNetCore.Mvc;

namespace FitOnWebSite.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
