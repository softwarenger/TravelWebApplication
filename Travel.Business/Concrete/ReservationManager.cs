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
    public class ReservationManager : IReservationService
    {
        private readonly IReservationDal _reservationDal;

        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }

        public List<Reservation> GetListApprovalReservation(int id)
        {
           return _reservationDal.GetListByFilter(x => x.AppUserId == id);
        }

        public void TAdd(Reservation TEntity)
        {
            _reservationDal.Add(TEntity);
        }

        public void TDelete(Reservation TEntity)
        {
            throw new NotImplementedException();
        }

        public Reservation TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Reservation TEntity)
        {
            throw new NotImplementedException();
        }
    }
}
