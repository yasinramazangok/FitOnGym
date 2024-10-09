using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FitOnWebSite.ViewComponents
{
    public class DashboardFirstPartial(Context context) : ViewComponent
    {
        private readonly Context _context = context; // Primary Constructor

        public IViewComponentResult Invoke(string pageName)
        {
            if (pageName == "Genel")
            {
                ViewBag.categories = _context.Categories.Count();
                ViewBag.services = _context.Services.Count();
                ViewBag.galleries = _context.Galleries.Count();
                ViewBag.contacts = _context.Contacts.Count();

            }
            else if (pageName == "Ekip Bilgileri")
            {
                ViewBag.teams = _context.Teams.Count();
                ViewBag.boxingCoach = _context.Teams.Where(t => t.Title == "BOKS ANTRENÖRÜ").Select(t => t.Name).FirstOrDefault();
                ViewBag.fitnessTrainer = _context.Teams.Where(t => t.Title == "FİTNESS EĞİTMENİ").Select(t => t.Name).FirstOrDefault();
                ViewBag.pilatesTrainer = _context.Teams.Where(t => t.Title == "PİLATES EĞİTMENİ").Select(t => t.Name).FirstOrDefault();
            }

            return View();

        }
    }
}
