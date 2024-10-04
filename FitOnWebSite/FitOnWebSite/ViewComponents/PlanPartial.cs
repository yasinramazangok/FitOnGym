using BusinessLayer.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace FitOnWebSite.ViewComponents
{
    public class PlanPartial(IPlanService planService) : ViewComponent
    {
        private readonly IPlanService _planService = planService; // Primary Constructor

        public IViewComponentResult Invoke()
        {
            var values = _planService.GetListAll();
            return View(values);
        }
    }
}
