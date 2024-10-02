using BusinessLayer.Abstracts;
using BusinessLayer.ValidationRules;
using EntityLayer.Concretes;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace FitOnWebSite.Controllers
{
    public class SocialMediaController(ISocialMediaService socialMediaService) : Controller
    {
        private readonly ISocialMediaService _socialMediaService = socialMediaService; // Primary Constructor

        public IActionResult Index()
        {
            var values = _socialMediaService.GetListAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddSocialMedia()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddSocialMedia(SocialMedia socialMedia)
        {
            _socialMediaService.Insert(socialMedia);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteSocialMedia(int id)
        {
            var value = _socialMediaService.GetById(id);
            _socialMediaService.Delete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateSocialMedia(int id)
        {
            var value = _socialMediaService.GetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateSocialMedia(SocialMedia socialMedia)
        {
            SocialMediaValidator socialMediaValidator = new SocialMediaValidator();
            ValidationResult result = socialMediaValidator.Validate(socialMedia);
            if (result.IsValid)
            {
                _socialMediaService.Update(socialMedia);
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
