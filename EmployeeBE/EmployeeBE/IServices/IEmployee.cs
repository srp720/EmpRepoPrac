using EmployeeBE.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeBE.IServices
{
    public interface IEmployee : IGenericInterface<Employee>
    {
        public Employee GetEmpByEmpName(string ename);
        public IEnumerable GetEmpByEmpId(long eid);
        public IEnumerable GetEmpByBdate(DateTime bdate);
        public IEnumerable GetEmpByJoinDt(DateTime joindt);
        public IEnumerable GetEmpByExperience(decimal exp);
        public IEnumerable GetEmpBySalary(long sal);
        public IEnumerable GetEmpByGender(string gen);
        public List<Employee> GetEmpByDeptName(string dname);
        public IEnumerable GetEmpByDeptId(long did);
    }
}
