using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Travel.Business.Abstract;

namespace TravelProject.MVC.ViewComponents.Default
{
    public class Statistics : ViewComponent
    {
        private readonly IGuideService _guideService;
        private readonly IDestinationService _destinationService;

        public Statistics(IGuideService guideService, IDestinationService destinationService)
        {
            _guideService = guideService;
            _destinationService = destinationService;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.Destination = _destinationService.TGetList().Count();
            ViewBag.Guide = _guideService.TGetList().Count();
            ViewBag.Customer = "250";
            return View();
        }
    }
}
