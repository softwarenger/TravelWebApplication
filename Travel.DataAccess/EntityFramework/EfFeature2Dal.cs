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
    public class EfFeature2Dal : GenericRepository<Feature2>, IFeature2Dal
    {
        public EfFeature2Dal(AppDbContext context) : base(context)
        {
        }
    }
}
