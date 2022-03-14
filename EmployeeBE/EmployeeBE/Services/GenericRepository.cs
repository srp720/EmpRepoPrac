using EmployeeBE.IServices;
using EmployeeBE.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeBE.Services
{
    public class GenericRepository<T> : IGenericInterface<T> where T : class
    {
        protected readonly EmployeeContext context;
        public GenericRepository(EmployeeContext _context)
        {
            context = _context;
        }
        public virtual bool Create(T entity)
        {
            context.Add(entity);
            context.SaveChanges();
            return true;
        }

        public virtual bool Delete(long id)
        {
            var a = context.Remove(id);
            context.SaveChanges();
            return true;
        }

        public virtual bool Update(long id, T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
            return true;
        }
        public virtual IEnumerable<T> GetAll()
        {
            return context.Set<T>();
        }
    }
}
