using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeBE.IServices
{
    public interface IGenericInterface<T> where T : class
    {
        bool Create(T entity);
        bool Update(long id, T entity);
        bool Delete(long id);
        IEnumerable<T> GetAll();


    }

}
