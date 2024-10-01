using BusinessLayer.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace FitOnWebSite.Controllers
{
    public class ServiceController(IServiceService serviceService) : Controller
    {
        private readonly IServiceService _serviceService = serviceService; // Primary Constructor

        public IActionResult Index()
        {
            var values = _serviceService.GetListAll();
            return View(values);
        }
    }
}
