using Microsoft.AspNetCore.Mvc;

namespace FitOnWebSite.ViewComponents
{
    public class DashboardThirdPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
