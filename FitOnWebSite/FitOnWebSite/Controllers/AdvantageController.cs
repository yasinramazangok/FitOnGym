using BusinessLayer.Abstracts;
using BusinessLayer.ValidationRules;
using EntityLayer.Concretes;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace FitOnWebSite.Controllers
{
    public class AdvantageController(IAdvantageService advantageService) : Controller
    {
        private readonly IAdvantageService _advantageService = advantageService; // Primary Constructor

        public IActionResult Index()
        {
            var values = _advantageService.GetListAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult UpdateAdvantage(int id)
        {
            var value = _advantageService.GetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateAdvantage(Advantage advantage)
        {
            AdvantageValidator advantageValidator = new AdvantageValidator();
            ValidationResult result = advantageValidator.Validate(advantage);
            if (result.IsValid)
            {
                _advantageService.Update(advantage);
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
