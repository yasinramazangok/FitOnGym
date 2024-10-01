using BusinessLayer.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace FitOnWebSite.Controllers
{
    public class ContactController(IContactService contactService) : Controller
    {
        private readonly IContactService _contactService = contactService; // Primary Constructors

        public IActionResult Index()
        {
            var values = _contactService.GetListAll();
            return View(values);
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
    }
}
