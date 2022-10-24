using Microsoft.AspNetCore.Mvc;
using Travel.Business.Abstract;

namespace TravelProject.MVC.ViewComponents.Default
{
    public class Testimonial:ViewComponent
    {
        private readonly ITestimonialService _testimonialService;

        public Testimonial(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _testimonialService.TGetList();
            return View(values);
        }
    }
}
