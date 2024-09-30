using Microsoft.AspNetCore.Mvc;

namespace FitOnWebSite.Controllers
{
    public class TeamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
