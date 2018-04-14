using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MASSalaryCalculation.Models;

namespace MASSalaryCalculation.Utils
{
    public class EmployeeFactory : IEmployeeFactory
    {
        public Employee CreateEmployee(String id, String name, String contractTypeName, String roleId, String roleName, String roleDescription, double hourlySalary, double monthlySalary)
        {
            if (contractTypeName.Equals("HourlySalaryEmployee"))
                return new HourlySalaryEmployee(id, name, contractTypeName, roleId, roleName, roleDescription, hourlySalary, monthlySalary);
            if (contractTypeName.Equals("MonthlySalaryEmployee"))
                return new MonthlySalaryEmployee(id, name, contractTypeName, roleId, roleName, roleDescription, hourlySalary, monthlySalary);

            return null;
        }
    }
}
