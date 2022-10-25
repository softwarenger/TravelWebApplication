using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Travel.Entity.Concrete;
using TravelProject.MVC.Areas.Member.Models;

namespace TravelProject.MVC.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    public class ProfileController : Controller
    {

        private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel userEditViewModel = new UserEditViewModel();

            userEditViewModel.Name = values.Name;
            userEditViewModel.SurName = values.Surname;
            userEditViewModel.PhoneNumber = values.PhoneNumber;
            userEditViewModel.Mail = values.Email;

            return View(userEditViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel userEditViewModel)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (userEditViewModel != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(userEditViewModel.Image.FileName);
                var imageName = Guid.NewGuid() + extension;
                var saveLacoation = resource + "/wwwroot/userımages/" + imageName;
                var stream = new FileStream(saveLacoation, FileMode.Create);
                await userEditViewModel.Image.CopyToAsync(stream);
                user.ImageUrl = imageName;

            }
            user.Name = userEditViewModel.Name;
            user.Surname = userEditViewModel.SurName;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, userEditViewModel.Password);
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("SıgnIn", "Login");
            }

            return View();
        }
    }
}
