using BusinessLayer.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace FitOnWebSite.ViewComponents
{
    public class CategoryPartial(ICategoryService categoryService) : ViewComponent
    {
        private readonly ICategoryService _categoryService = categoryService; // Primary Constructor

        public IViewComponentResult Invoke()
        {
            var values = _categoryService.GetListAll();
            return View(values);
        }
    }
}
