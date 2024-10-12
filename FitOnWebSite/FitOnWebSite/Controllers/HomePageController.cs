using BusinessLayer.Abstracts;
using BusinessLayer.ValidationRules;
using EntityLayer.Concretes;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FitOnWebSite.Controllers
{
    [Authorize]
    public class HomePageController(IHomePageService homePageService) : Controller
    {
        private readonly IHomePageService _homePageService = homePageService; // Primary Constructor

        public IActionResult Index()
        {
            var values = _homePageService.GetListAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddHomePage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddHomePage(HomePage homePage)
        {
            _homePageService.Insert(homePage);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteHomePage(int id)
        {
            var value = _homePageService.GetById(id);
            _homePageService.Delete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateHomePage(int id)
        {
            var value = _homePageService.GetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateHomePage(HomePage homePage)
        {
            HomePageValidator homePageValidator = new HomePageValidator();
            ValidationResult result = homePageValidator.Validate(homePage);
            if (result.IsValid)
            {
                _homePageService.Update(homePage);
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
