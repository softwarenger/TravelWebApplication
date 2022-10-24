using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Travel.Business.Abstract;

namespace TravelProject.MVC.ViewComponents.Default
{
     
    public class SubAbout : ViewComponent
    {
        private readonly ISubAboutService _subAboutService;

        public SubAbout(ISubAboutService subAboutService)
        {
            _subAboutService = subAboutService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _subAboutService.TGetList();
            return View(values);
        }
    }
}
