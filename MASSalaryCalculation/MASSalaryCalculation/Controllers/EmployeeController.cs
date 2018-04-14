using System;
using System.Collections.Generic;
using MASSalaryCalculation.BusinessLogic;
using Microsoft.AspNetCore.Mvc;

namespace MASSalaryCalculation.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        EmployeeManager _employeeManager;
        
        public EmployeeController()
        {
            _employeeManager = new EmployeeManager();
        }

        [HttpGet("[action]")]
        public IEnumerable<MASSalaryCalculation.Models.Employee> GetEmployees(String id)
        {               
            return String.IsNullOrEmpty(id) ? _employeeManager.GetEmployees() : _employeeManager.GetEmployee(id);
        }
    }
}
