using BusinessLayer.Abstracts;
using DocumentFormat.OpenXml.Validation;
using Microsoft.AspNetCore.Mvc;

namespace FitOnWebSite.ViewComponents
{
    public class GalleryPartial(IGalleryService galleryService) : ViewComponent
    {
        private readonly IGalleryService _galleryService = galleryService; // Primary Constructor

        public IViewComponentResult Invoke()
        {
            var values = _galleryService.GetListAll();
            return View(values);
        }
    }
}
