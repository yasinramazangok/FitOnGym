using FitOnWebSite.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FitOnWebSite.Controllers
{
    public class ProfileController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;

        public ProfileController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditModel userEditModel = new UserEditModel();
            userEditModel.Mail = values.Email;
            userEditModel.Phone = values.PhoneNumber;
            return View(userEditModel);
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserEditModel p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            if (p.Password == p.PasswordConfirm)
            {
                values.Email = p.Mail;
                values.PhoneNumber = p.Phone;
                values.PasswordHash = _userManager.PasswordHasher.HashPassword(values, p.Password);
                var result = await _userManager.UpdateAsync(values);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
            }
            return View();
        }
    }
}
