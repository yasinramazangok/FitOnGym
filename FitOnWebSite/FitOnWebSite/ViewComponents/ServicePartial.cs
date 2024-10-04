using BusinessLayer.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace FitOnWebSite.ViewComponents
{
    public class ServicePartial(IServiceService serviceService) : ViewComponent
    {
        private readonly IServiceService _serviceService = serviceService; // Primary Constructor

        public IViewComponentResult Invoke()
        {
            var values = _serviceService.GetListAll();
            return View(values);
        }
    }
}
