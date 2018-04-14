using MASSalaryCalculation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MASSalaryCalculation.Utils
{
    interface IEmployeeFactory
    {
        Employee CreateEmployee(String id, String name, String contractTypeName, String roleId, String roleName, String roleDescription, double hourlySalary, double monthlySalary);
    }
}
