using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel.Entity.Concrete;

namespace Travel.Business.Abstract
{
    public interface IReservationService:IGenericService<Reservation>
    {
        List<Reservation> GetListApprovalReservation(int id);
    }
}
