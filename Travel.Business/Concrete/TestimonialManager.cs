using System;
using System.Collections.Generic;
using Travel.Business.Abstract;
using Travel.DataAccess.Abstract;
using Travel.Entity.Concrete;

namespace Travel.Business.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void TAdd(Testimonial TEntity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Testimonial TEntity)
        {
            throw new NotImplementedException();
        }

        public Testimonial TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Testimonial> TGetList()
        {
            return _testimonialDal.GetAll();
        }

        public void TUpdate(Testimonial TEntity)
        {
            throw new NotImplementedException();
        }
    }
}
