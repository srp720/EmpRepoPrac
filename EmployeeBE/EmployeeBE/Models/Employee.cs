using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EmployeeBE.Models
{
    public partial class Employee
    {
        public long EmpId { get; set; }
        public string EmpName { get; set; }
        public DateTime EmpJoinDate { get; set; }
        public DateTime EmpExpierience { get; set; }
        public long EmpDepartmentId { get; set; }
        public DateTime EmpBirthDate { get; set; }
        public int EmpSalary { get; set; }
        public string EmpEmailId { get; set; }
        public string EmpMobNo { get; set; }
        public string EmpGender { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Department EmpDepartment { get; set; }
    }
}
