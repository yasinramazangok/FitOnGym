using BusinessLayer.Abstracts;
using BusinessLayer.ValidationRules;
using EntityLayer.Concretes;
using FluentValidation;
using FluentValidation.Results;
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

        public IActionResult Home()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddService()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddService(Service service)
        {
            _serviceService.Insert(service);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteService(int id)
        {
            var value = _serviceService.GetById(id);
            _serviceService.Delete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateService(int id)
        {
            var value = _serviceService.GetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateService(Service service)
        {
            ServiceValidator serviceValidator = new ServiceValidator();
            ValidationResult result = serviceValidator.Validate(service);
            if (result.IsValid)
            {
                _serviceService.Update(service);
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
