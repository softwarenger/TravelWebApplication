using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Travel.Business.Abstract;
using Travel.Business.Concrete;
using Travel.DataAccess.EntityFramework;

namespace TravelProject.MVC.ViewComponents.Default
{
    public class Feature : ViewComponent
    {
        private readonly IFeatureService _featureService;

        public Feature(IFeatureService featureService)
        {
            _featureService = featureService;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.Image1 = _featureService.TGetList().Select(p => p.Image).FirstOrDefault();
            return View();
        }
    }
}
