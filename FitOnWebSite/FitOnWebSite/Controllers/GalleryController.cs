using BusinessLayer.Abstracts;
using BusinessLayer.ValidationRules;
using EntityLayer.Concretes;
using FluentValidation;
using FluentValidation.Results;
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

        public IActionResult Home()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddGallery()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddGallery(Gallery gallery)
        {
            _galleryService.Insert(gallery);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteGallery(int id)
        {
            var value = _galleryService.GetById(id);
            _galleryService.Delete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateGallery(int id)
        {
            var value = _galleryService.GetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateGallery(Gallery gallery)
        {
            GalleryValidator categoryValidator = new GalleryValidator();
            ValidationResult result = categoryValidator.Validate(gallery);
            if (result.IsValid)
            {
                _galleryService.Update(gallery);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}
