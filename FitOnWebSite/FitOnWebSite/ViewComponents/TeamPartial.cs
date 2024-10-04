using BusinessLayer.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace FitOnWebSite.ViewComponents
{
    public class TeamPartial(ITeamService teamService) : ViewComponent
    {
        private readonly ITeamService _teamService = teamService; // Primary Constructor

        public IViewComponentResult Invoke()
        {
            var values = _teamService.GetListAll();
            return View(values);
        }
    }
}
