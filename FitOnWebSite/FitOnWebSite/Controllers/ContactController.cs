using BusinessLayer.Abstracts;
using EntityLayer.Concretes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FitOnWebSite.Controllers
{
    [Authorize]
    public class ContactController(IContactService contactService) : Controller
    {
        private readonly IContactService _contactService = contactService; // Primary Constructors

        public IActionResult Index()
        {
            var values = _contactService.GetListAll();
            return View(values);
        }

        [AllowAnonymous]
        public IActionResult Home()
        {
            return View();
        }

        public IActionResult DeleteMessage(int id)
        {
            var value = _contactService.GetById(id);
            _contactService.Delete(value);
            return RedirectToAction("Index");
        }

        public IActionResult GetMessageDetails(int id)
        {
            var values = _contactService.GetById(id);
            return View(values);
        }

        [HttpGet]
        [AllowAnonymous]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult SendMessage(Contact contact)
        {
            contact.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            _contactService.Insert(contact);
            return RedirectToAction("Home", "Contact");
        }
    }
}
