using FitOnWebSite.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FitOnWebSite.Controllers
{
    [Authorize]
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
            var values = await _userManager.FindByNameAsync(User!.Identity!.Name!);
            UserEditModel userEditModel = new UserEditModel();
            userEditModel.Name = values!.UserName;
            userEditModel.PhoneNumber = values.PhoneNumber;
            return View(userEditModel);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserEditModel userEditModel)
        {
            var values = await _userManager.FindByNameAsync(User!.Identity!.Name!);
            if (userEditModel.Password == userEditModel.PasswordConfirm)
            {
                values!.UserName = userEditModel.Name;
                values.PhoneNumber = userEditModel.PhoneNumber;
                values.PasswordHash = _userManager.PasswordHasher.HashPassword(values, userEditModel!.Password!);
                var result = await _userManager.UpdateAsync(values);
                if (result.Succeeded)
                {
                    return RedirectToAction("Login", "Account");
                }
            }
            return View();
        }
    }
}
