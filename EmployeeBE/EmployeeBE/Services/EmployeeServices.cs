using EmployeeBE.IServices;
using EmployeeBE.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeBE.Services
{
    public class EmployeeServices : GenericRepository<Employee>, IEmployee
    {
        public EmployeeServices(EmployeeContext context) : base(context)
        {
        }

        // Add employee
        public override bool Create(Employee emp)
        {
            var result = context.Employee.Add(emp);
            context.SaveChanges();
            return true;
        }

        // Update Employee
        public override bool Update(long id, Employee emp)
        {
            var existingemp = context.Employee.Find(id);

            if (existingemp != null)
            {
                existingemp.EmpId = emp.EmpId;
                existingemp.EmpName = emp.EmpName;
                existingemp.EmpDepartmentId = emp.EmpDepartmentId;
                existingemp.EmpEmailId = emp.EmpEmailId;
                existingemp.EmpBirthDate = emp.EmpBirthDate;
                existingemp.EmpExpierience = emp.EmpExpierience;
                existingemp.EmpGender = emp.EmpGender;                
                existingemp.EmpMobNo = emp.EmpMobNo;           
                existingemp.EmpSalary = emp.EmpSalary;
                existingemp.UpdatedBy = emp.UpdatedBy;
                existingemp.UpdatedAt = DateTime.Now;
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }

        // Delete Employee
        public override bool Delete(long id)
        {
            var existingemp = context.Employee.Find(id);

            if (existingemp != null)
            {
                context.Employee.Remove(existingemp);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        // Get by Id
        public IEnumerable GetEmpByEmpId(long empid)
        {
            var emp = context.Employee.Where(x => x.EmpId == empid);
            return emp;
        }

        // Get all by Id
        public override IEnumerable<Employee> GetAll()
        {
            var emp = context.Employee;
            return emp;
        }

        // Get by Name
        public Employee GetEmpByEmpName(string name)
        {
            var emp = context.Employee.SingleOrDefault(x => x.EmpName == name);
            return emp;
        }

        // Get by BirthDate
        public IEnumerable GetEmpByBdate(DateTime bdate)
        {
            var emp = context.Employee.Where(x => x.EmpBirthDate == bdate.Date).ToList();
            return emp;
        }

        // Get by JoinDate
        public IEnumerable GetEmpByJoinDt(DateTime jndt)
        {
            var post = context.Employee.Where(x => x.EmpJoinDate == jndt.Date).ToList();
            return post;
        }

        // Get by Experience
        public IEnumerable GetEmpByExperience(DateTime exp)
        {
            var post = context.Employee.Where(x => x.EmpExpierience == exp.Date).ToList();
            return post;
        }

        // Get by Salary
        public IEnumerable GetEmpBySalary(long sal)
        {
            var empsal = context.Employee.Where(x => x.EmpSalary == sal);
            return empsal;
        }

        // Get by Gender
        public IEnumerable GetEmpByGender(string gender)
        {
            var empgen = context.Employee.Where(x => x.EmpGender == gender);
            return gender;
        }

        // Get by DeptName
        public Department GetEmpByDeptName(string dname)
        {
            var deptname = context.Department.Include(x => x.DeptName).SingleOrDefault(x => x.DeptName == dname);
            return deptname;
        }

        // Get by Dept id
        public IEnumerable GetEmpByDeptId(long depid)
        {
            var empid = context.Employee.Where(x => x.EmpDepartmentId == depid);
            return empid;
        }
    }
}
