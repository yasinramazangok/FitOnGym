using BusinessLayer.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace FitOnWebSite.Controllers
{
    public class CategoryController(ICategoryService categoryService) : Controller
    {
        private readonly ICategoryService _categoryService = categoryService; // Primary Constructor

        public IActionResult Index()
        {
            var values = _categoryService.GetListAll();
            return View(values);
        }
    }
}
