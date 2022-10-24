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
    public class FeatureManager : IFeatureService
    {
        private readonly IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void TAdd(Feature TEntity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Feature TEntity)
        {
            throw new NotImplementedException();
        }

        public Feature TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Feature> TGetList()
        {
            return _featureDal.GetAll();
        }

        public void TUpdate(Feature TEntity)
        {
            throw new NotImplementedException();
        }
    }
}
