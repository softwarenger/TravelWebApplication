using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel.Business.Abstract;
using Travel.DataAccess.Abstract;
using Travel.Entity.Concrete;

namespace Travel.Business.Concrete
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void TAdd(About TEntity)
        {
            _aboutDal.Add(TEntity);
        }

        public void TDelete(About TEntity)
        {
            _aboutDal.Delete(TEntity);
        }

        public About TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<About> TGetList()
        {
            return _aboutDal.GetAll();
        }

        public void TUpdate(About TEntity)
        {
            _aboutDal.Update(TEntity);
        }
    }
}
