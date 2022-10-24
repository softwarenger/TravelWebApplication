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
    public class EfDestinationDal : GenericRepository<Destination>, IDestinationDal
    {      
        public EfDestinationDal(AppDbContext context) : base(context)
        {
        }
    }
}
