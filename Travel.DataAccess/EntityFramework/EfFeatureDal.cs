using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel.DataAccess.Abstract;
using Travel.DataAccess.Concrete;
using Travel.DataAccess.Repository;
using Travel.Entity.Concrete;

namespace Travel.DataAccess.EntityFramework
{
    public class EfFeatureDal : GenericRepository<Feature>, IFeatureDal
    {
        public EfFeatureDal(AppDbContext context) : base(context)
        {
        }
    }
}
