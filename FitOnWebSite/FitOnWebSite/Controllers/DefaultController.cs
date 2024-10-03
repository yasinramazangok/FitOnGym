using BusinessLayer.Abstracts;
using EntityLayer.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace FitOnWebSite.Controllers
{
    
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }

        //[HttpPost]
        //public IActionResult SendMessage(Contact contact)
        //{
        //    contact.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
        //    _contactService.Insert(contact);
        //    return RedirectToAction("Index", "Default");
        //}
        //public PartialViewResult ScriptPartial()
        //{
        //    return PartialView();
        //}
    }
}
