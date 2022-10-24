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
    public class EfNewsLetterDal : GenericRepository<NewsLetter>, INewsLetterDal
    {
        public EfNewsLetterDal(AppDbContext context) : base(context)
        {
        }
    }
}
