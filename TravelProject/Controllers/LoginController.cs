using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Travel.Entity.Concrete;
using TravelProject.MVC.Models;

namespace TravelProject.MVC.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(UserRegisterViewModel userRegisterViewModel)
        {
            AppUser appUser = new AppUser()
            {
                Name = userRegisterViewModel.Name,
                Surname = userRegisterViewModel.SurName,
                Email = userRegisterViewModel.Mail,
                UserName = userRegisterViewModel.UserName
            };
            if (userRegisterViewModel.Password == userRegisterViewModel.ConfirmPassword)
            {
                var result = await _userManager.CreateAsync(appUser, userRegisterViewModel.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("SıgnIn");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(userRegisterViewModel);
        }
        [HttpGet]
        public IActionResult SıgnIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SıgnIn(UserLoginViewModel userLoginViewModel)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(userLoginViewModel.UserName, userLoginViewModel.Password, false, true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index","Profile",new { area="Member"});

                }
                else
                {
                    return RedirectToAction("SıgnIn", "Login");
                }
            }
            return View();
        }
    }
}
