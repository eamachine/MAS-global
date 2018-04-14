using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MASSalaryCalculation.Models
{
    public class HourlySalaryEmployee : Employee
    {
        public HourlySalaryEmployee(String id, String name, String contractTypeName, String roleId, String roleName, String roleDescription, double hourlySalary, double monthlySalary) : base(id, name, contractTypeName, roleId, roleName, roleDescription, hourlySalary, monthlySalary)
        {
            //Aditional HourlySalaryEmployee Logic
        }

        public override double CalculateAnualSalary()
        {
            return 120 * 12 * this.HourlySalary;
        }
    }
}
