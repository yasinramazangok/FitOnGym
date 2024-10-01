using BusinessLayer.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace FitOnWebSite.Controllers
{
    public class GalleryController(IGalleryService galleryService) : Controller
    {
        private readonly IGalleryService _galleryService = galleryService; // Primary Constructor

        public IActionResult Index()
        {
            var values = _galleryService.GetListAll();
            return View(values);
        }
    }
}
