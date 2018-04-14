using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MASSalaryCalculation.Models
{
    public class MonthlySalaryEmployee : Employee
    {
        public MonthlySalaryEmployee(String id, String name, String contractTypeName, String roleId, String roleName, String roleDescription, double hourlySalary, double monthlySalary) : base(id, name, contractTypeName, roleId, roleName, roleDescription, hourlySalary, monthlySalary)
        {
            //Aditional MonthlySalaryEmployee Logic
        }

        public override double CalculateAnualSalary()
        {
            return 12 * this.MonthlySalary;
        }
    }
}
