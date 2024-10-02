using BusinessLayer.Abstracts;
using BusinessLayer.ValidationRules;
using EntityLayer.Concretes;
using FluentValidation.Results;
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

        [HttpGet]
        public IActionResult AddPlan()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPlan(Plan plan)
        {
            _planService.Insert(plan);
            return RedirectToAction("Index");
        }

        public IActionResult DeletePlan(int id)
        {
            var value = _planService.GetById(id);
            _planService.Delete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdatePlan(int id)
        {
            var value = _planService.GetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdatePlan(Plan plan)
        {
            PlanValidator planValidator = new PlanValidator();
            ValidationResult result = planValidator.Validate(plan);
            if (result.IsValid)
            {
                _planService.Update(plan);
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
