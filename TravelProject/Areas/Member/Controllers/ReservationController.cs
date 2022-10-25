using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Travel.Business.Abstract;
using Travel.Entity.Concrete;

namespace TravelProject.MVC.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    public class ReservationController : Controller
    {
        private readonly IDestinationService _destinationService;
        private readonly IReservationService _reservationService;

        public ReservationController(IDestinationService destinationService, IReservationService reservationService)
        {
            _destinationService = destinationService;
            _reservationService = reservationService;
        }

        public IActionResult MyActiveReservation()
        {
            return View();
        }
        public IActionResult MyOldReservation()
        {
            return View();
        }


        [HttpGet]
        public IActionResult NewReservation()
        {
            List<SelectListItem> values = (from x in _destinationService.TGetList()
                                           select new SelectListItem
                                           {
                                               Text = x.City,
                                               Value = x.DestinationId.ToString()
                                           }).ToList();
            ViewBag.v = values;
            return View();
        }
        [HttpPost]
        public IActionResult NewReservation(Reservation reservation)
        {
            reservation.AppUserId = 1;
            _reservationService.TAdd(reservation);
            return RedirectToAction("MyActiveReservation");
        }


    }
}
