using BusinessLayer.Abstracts;
using FitOnWebSite.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FitOnWebSite.Controllers
{
    public class HomeController(IHomeService homeService) : Controller
    {
        private readonly IHomeService _homeService = homeService; // Primary Constructor

        public IActionResult Index()
        {
            var values = _homeService.GetListAll();
            return View(values);
        }

    }
}
