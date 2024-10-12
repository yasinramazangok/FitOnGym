using BusinessLayer.Abstracts;
using BusinessLayer.ValidationRules;
using EntityLayer.Concretes;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FitOnWebSite.Controllers
{
    [Authorize]
    public class AboutController(IAboutService aboutService) : Controller
    {
        private readonly IAboutService _aboutService = aboutService; // Primary Constructor

        public IActionResult Index()
        {
            var values = _aboutService.GetListAll();
            return View(values);
        }

        [AllowAnonymous]
        public IActionResult Home()
        {
            return View();
        }

        [HttpGet]
        public IActionResult UpdateAbout(int id)
        {
            var value = _aboutService.GetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateAbout(About about)
        {
            AboutValidator aboutValidator = new AboutValidator();
            ValidationResult result = aboutValidator.Validate(about);
            if (result.IsValid)
            {
                _aboutService.Update(about);
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
