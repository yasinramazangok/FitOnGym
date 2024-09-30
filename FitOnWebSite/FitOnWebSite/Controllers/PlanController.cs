using Microsoft.AspNetCore.Mvc;

namespace FitOnWebSite.Controllers
{
    public class PlanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
