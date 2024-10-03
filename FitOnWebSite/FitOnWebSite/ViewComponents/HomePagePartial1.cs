using BusinessLayer.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace FitOnWebSite.ViewComponents
{
    public class HomePagePartial1(IHomePageService homePageService) : ViewComponent
    {
        private readonly IHomePageService _homePageService = homePageService; // Primary Constructor

        public IViewComponentResult Invoke()
        {
            var values = _homePageService.GetListAll();
            return View(values);
        }
    }
}
