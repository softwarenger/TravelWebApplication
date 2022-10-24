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
    public class GuideManager : IGuideService
    {
        private readonly IGuideDal _guideDal;

        public GuideManager(IGuideDal guideDal)
        {
            _guideDal = guideDal;
        }

        public void TAdd(Guide TEntity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Guide TEntity)
        {
            throw new NotImplementedException();
        }

        public Guide TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Guide> TGetList()
        {
            return _guideDal.GetAll();

        }

        public void TUpdate(Guide TEntity)
        {
            throw new NotImplementedException();
        }
    }
}
