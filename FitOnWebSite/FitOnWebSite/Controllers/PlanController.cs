using BusinessLayer.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace FitOnWebSite.Controllers
{
    public class PlanController(IPlanService planService) : Controller
    {
        private readonly IPlanService _planService = planService; // Primary Constructor

        public IActionResult Index()
        {
            var values = _planService.GetListAll();
            return View(values);
        }
    }
}
