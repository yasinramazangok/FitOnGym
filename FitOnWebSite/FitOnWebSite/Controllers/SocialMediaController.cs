using BusinessLayer.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace FitOnWebSite.Controllers
{
    public class SocialMediaController(ISocialMediaService socialMediaService) : Controller
    {
        private readonly ISocialMediaService _socialMediaService = socialMediaService; // Primary Constructor

        public IActionResult Index()
        {
            var values = _socialMediaService.GetListAll();
            return View(values);
        }
    }
}
