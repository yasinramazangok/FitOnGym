using BusinessLayer.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace FitOnWebSite.ViewComponents
{
    public class AboutPartial(IAboutService aboutService) : ViewComponent
    {
        private readonly IAboutService _aboutService = aboutService; // Primary Constructor

        public IViewComponentResult Invoke()
        {
            var values = _aboutService.GetListAll();
            return View(values);
        }
    }
}
