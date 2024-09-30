using Microsoft.AspNetCore.Mvc;

namespace FitOnWebSite.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
