using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel.Business.Abstract
{
    public interface IGenericService<T>
    {
        void TAdd(T TEntity);
        void TDelete(T TEntity);
        void TUpdate(T TEntity);
        List<T> TGetList();
        T TGetById(int id);

    }
}
