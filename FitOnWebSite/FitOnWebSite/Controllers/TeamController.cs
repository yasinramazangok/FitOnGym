﻿using BusinessLayer.Abstracts;
using BusinessLayer.ValidationRules;
using EntityLayer.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace FitOnWebSite.Controllers
{
    public class TeamController(ITeamService teamService) : Controller
    {
        private readonly ITeamService _teamService = teamService; // Primary Constructor

        public IActionResult Index()
        {
            var values = _teamService.GetListAll();
            return View(values);
        }

        //[HttpGet]
        //public IActionResult AddService()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult AddService(Service service)
        //{
        //    _serviceService.Insert(service);
        //    return RedirectToAction("Index");
        //}

        //public IActionResult DeleteService(int id)
        //{
        //    var value = _serviceService.GetById(id);
        //    _serviceService.Delete(value);
        //    return RedirectToAction("Index");
        //}

        //[HttpGet]
        //public IActionResult UpdateService(int id)
        //{
        //    var value = _serviceService.GetById(id);
        //    return View(value);
        //}

        //[HttpPost]
        //public IActionResult UpdateService(Service service)
        //{
        //    ServiceValidator serviceValidator = new ServiceValidator();
        //    ValidationResult result = serviceValidator.Validate(service);
        //    if (result.IsValid)
        //    {
        //        _serviceService.Update(service);
        //        return RedirectToAction("Index");
        //    }
        //    else
        //    {
        //        foreach (var item in result.Errors)
        //        {
        //            ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
        //        }
        //    }
        //    return View();
        //}
    }
}
