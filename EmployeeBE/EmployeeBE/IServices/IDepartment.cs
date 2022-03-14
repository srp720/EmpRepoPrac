using EmployeeBE.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeBE.IServices
{
    public interface IDepartment : IGenericInterface<Department>
    {
        public Department GetDeptByDeptName(string dname);

        public IEnumerable GetDeptByDeptId(long did);
        
    }
}
