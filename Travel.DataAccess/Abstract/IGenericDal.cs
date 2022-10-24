using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Travel.DataAccess.Abstract
{
    public interface IGenericDal<T>
    {
        void Add(T TEntity);
        void Delete(T TEntity);
        void Update(T TEntity);
        List<T> GetAll();
        T GetById(int id);
        List<T> GetListByFilter(Expression<Func<T, bool>> expression);
    }
}
