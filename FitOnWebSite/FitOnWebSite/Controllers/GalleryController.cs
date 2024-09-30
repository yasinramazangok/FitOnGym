using Microsoft.AspNetCore.Mvc;

namespace FitOnWebSite.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
