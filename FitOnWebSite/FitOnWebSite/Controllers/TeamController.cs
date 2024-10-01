using BusinessLayer.Abstracts;
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
    }
}
