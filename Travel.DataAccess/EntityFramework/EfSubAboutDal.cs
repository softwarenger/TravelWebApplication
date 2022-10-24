using Travel.DataAccess.Abstract;
using Travel.DataAccess.Concrete;
using Travel.DataAccess.Repository;
using Travel.Entity.Concrete;

namespace Travel.DataAccess.EntityFramework
{
    public class EfSubAboutDal : GenericRepository<SubAbout>, ISubAboutDal
    {
        public EfSubAboutDal(AppDbContext context) : base(context)
        {
        }
    }
}
