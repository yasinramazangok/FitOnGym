using BusinessLayer.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace FitOnWebSite.ViewComponents
{
    public class AdvantagePartial(IAdvantageService advantageService) : ViewComponent
    {
        private readonly IAdvantageService _advantageService = advantageService; // Primary Constructor

        public IViewComponentResult Invoke()
        {
            var values = _advantageService.GetListAll();   
             return View(values);
        }
    }
}
