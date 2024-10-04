using BusinessLayer.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace FitOnWebSite.ViewComponents
{
    public class SocialMediaPartial(ISocialMediaService socialMediaService) : ViewComponent
    {
        private readonly ISocialMediaService _socialMediaService = socialMediaService; // Primary Constructor

        public IViewComponentResult Invoke()
        {
            var values = _socialMediaService.GetListAll();
            return View(values);
        }
    }
}
