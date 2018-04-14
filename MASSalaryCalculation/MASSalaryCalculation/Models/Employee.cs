using System;

namespace MASSalaryCalculation.Models
{
    public abstract class Employee
    {
        public String Id { get; set; }
        public String Name { get; set; }
        public String ContractTypeName { get; set; }
        public String RoleId { get; set; }
        public String RoleName { get; set; }
        public String RoleDescription { get; set; }
        public double HourlySalary { get; set; }
        public double MonthlySalary { get; set; }
        public double AnualSalary { get; set; }

        protected Employee(String id, String name, String contractTypeName, String roleId, String roleName, String roleDescription, double hourlySalary, double monthlySalary)
        {
            Id = id;
            Name = name;
            ContractTypeName = contractTypeName;
            RoleId = roleId;
            RoleName = roleName;
            RoleDescription = roleDescription;
            HourlySalary = hourlySalary;
            MonthlySalary = monthlySalary;
            AnualSalary = CalculateAnualSalary();
        }

        public abstract double CalculateAnualSalary();
    }
}
