﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
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
    }
}
