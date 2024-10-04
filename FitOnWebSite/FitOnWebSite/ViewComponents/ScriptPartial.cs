using Microsoft.AspNetCore.Mvc;

namespace FitOnWebSite.ViewComponents
{
    public class ScriptPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
