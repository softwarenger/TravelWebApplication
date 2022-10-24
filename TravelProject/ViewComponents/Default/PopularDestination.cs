using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Travel.Business.Abstract;
using Travel.Business.Concrete;
using Travel.DataAccess.Abstract;
using Travel.DataAccess.EntityFramework;

namespace TravelProject.MVC.ViewComponents.Default
{
    public class PopularDestination : ViewComponent
    {
        private readonly IDestinationService _destinationService;

        public PopularDestination(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _destinationService.TGetList();
            return View(values);
        }
    }
}
