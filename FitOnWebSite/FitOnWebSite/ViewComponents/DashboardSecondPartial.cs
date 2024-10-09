using Microsoft.AspNetCore.Mvc;

namespace FitOnWebSite.ViewComponents
{
    public class DashboardSecondPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
