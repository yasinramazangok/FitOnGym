using BusinessLayer.Abstracts;
using BusinessLayer.ValidationRules;
using EntityLayer.Concretes;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace FitOnWebSite.Controllers
{
    public class AddressController(IAddressService addressService) : Controller
    {
        private readonly IAddressService _addressService = addressService; // Primary Constructor

        public IActionResult Index()
        {
            var values = _addressService.GetListAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult UpdateAddress(int id)
        {
            var value = _addressService.GetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateAddress(Address address)
        {
            AddressValidator addressValidator = new AddressValidator();
            ValidationResult result = addressValidator.Validate(address);
            if (result.IsValid)
            {
                _addressService.Update(address);
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
