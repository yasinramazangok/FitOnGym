using FitOnWebSite.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FitOnWebSite.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        // Login and Sign Up Operations

        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public LoginController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(loginModel.UserName, loginModel.Password, false, false); // username, password, isPersistent, lockoutOnFailure
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Admin");
                }
                else
                {

                    // Hata durumunu kontrol et
                    if (result.IsLockedOut)
                    {
                        ModelState.AddModelError("", "Kullanıcı hesabınız kilitlenmiştir.");
                    }
                    else if (result.IsNotAllowed)
                    {
                        ModelState.AddModelError("", "Bu kullanıcı için giriş yapılmasına izin verilmiyor.");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Kullanıcı adı veya şifre hatalı.");
                    }
                        return View();
                        //return RedirectToAction("Index");
                }
                Console.WriteLine("Yönlendirme sonrası durum kodu: " + HttpContext.Response.StatusCode);
            }
            return View();
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(RegisterModel registerModel)
        {
            IdentityUser ıdentityUser = new IdentityUser()
            {
                Id = "1",
                UserName = registerModel.UserName,
                Email = registerModel.Email
            };
            if (registerModel.Password == registerModel.PasswordConfirm)
            {
                var result = await _userManager.CreateAsync(ıdentityUser, registerModel.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(registerModel);
        }
    }
}
