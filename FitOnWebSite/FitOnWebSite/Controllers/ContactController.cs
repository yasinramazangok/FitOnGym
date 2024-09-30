using Microsoft.AspNetCore.Mvc;

namespace FitOnWebSite.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
