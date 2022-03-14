using EmployeeBE.IServices;
using EmployeeBE.Models;
using EmployeeBE.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : BaseController
    {
        private readonly IEmployee _employee;
        private readonly IDepartment _department;
        public EmployeeController(IEmployee employee, IDepartment department)
        {
            _employee = employee;
            _department = department;
        }

        // POST Employee
        [HttpPost]
        public ActionResult<Employee> AddEmployee(Employee emps)
        {
            emps.UpdatedBy = "EmpId";
            emps.CreatedBy = "EmpId";
            emps.CreatedAt = DateTime.Now;
            emps.UpdatedAt = DateTime.Now;
            bool created = _employee.Create(emps);
            if (created)
                return StatusCode(StatusCodes.Status201Created, new Response { Status = "Created", Message = "Data Added successfully!" });
            return StatusCode(500, new Response { Status = "Error", Message = "Something went wrong. Please contact Administrator!" });
        }

        // GET: api/cities
        [HttpGet]
        public ActionResult<IEnumerable<Employee>> GetAll()
        {
            return Ok(_employee.GetAll());
        }


    }
}
