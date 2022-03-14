using EmployeeBE.IServices;
using EmployeeBE.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeBE.Services
{
    public class DepartmentServices : GenericRepository<Department>, IDepartment
    {
        public DepartmentServices(EmployeeContext context) : base(context)
        {
        }

        // Add department
        public override bool Create(Department dep)
        {
            var result = context.Department.Add(dep);
            context.SaveChanges();
            return true;
        }

        // Delete department
        public override bool Delete(long id)
        {
            var existingdept = context.Department.Find(id);

            if (existingdept != null)
            {
                context.Department.Remove(existingdept);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        // Update department
        public override bool Update(long id, Department dept)
        {
            var existingdep = context.Department.Find(id);

            if (existingdep != null)
            {
                existingdep.DeptId = dept.DeptId;
                existingdep.DeptName = dept.DeptName;
                existingdep.UpdatedBy = dept.UpdatedBy;
                existingdep.UpdatedAt = DateTime.Now;
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }

        // Get all department
        public override IEnumerable<Department> GetAll()
        {
            var dep = context.Department;
            return dep;
        }

        // Get department by id
        public IEnumerable GetDeptByDeptId(long deptid)
        {
            var depid = context.Department.Where(x => x.DeptId == deptid);
            return depid;
        }

        // Get department by name
        public Department GetDeptByDeptName(string name)
        {
            var depname = context.Department.SingleOrDefault(x => x.DeptName == name);
            return depname;
        }
    }
}
