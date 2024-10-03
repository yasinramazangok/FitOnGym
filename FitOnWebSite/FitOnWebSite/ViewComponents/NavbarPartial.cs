using Microsoft.AspNetCore.Mvc;

namespace FitOnWebSite.ViewComponents
{
    public class NavbarPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
