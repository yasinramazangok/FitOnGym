using Microsoft.AspNetCore.Mvc;

namespace FitOnWebSite.Controllers
{
    public class SocialMediaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
