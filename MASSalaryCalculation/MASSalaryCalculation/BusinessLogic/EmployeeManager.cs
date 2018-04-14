using MASSalaryCalculation.DTOs;
using MASSalaryCalculation.Repository;
using MASSalaryCalculation.Utils;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MASSalaryCalculation.BusinessLogic
{
    public class EmployeeManager
    {
        private IEmployeeRepository _employeeRepository;
        private IEmployeeFactory _employeeFactory;

        private List<MASSalaryCalculation.Models.Employee> employees;

        public EmployeeManager()
        {
            _employeeFactory = new EmployeeFactory();
            _employeeRepository = new EmployeeRepository();

            employees = new List<Models.Employee>();

            FetchEmployees();
        }

        private void FetchEmployees()
        {
            Task<List<Employee>> Etask = _employeeRepository.GetAsync();

            List<Employee> employeesDTOs = Etask.Result;

            foreach (var employee in employeesDTOs)
                employees.Add(_employeeFactory.CreateEmployee(employee.Id, employee.Name, employee.ContractTypeName, employee.RoleId, employee.RoleName, employee.RoleDescription, employee.HourlySalary, employee.MonthlySalary));

        }

        public List<MASSalaryCalculation.Models.Employee> GetEmployees()
        {
            return employees;
        }

        public List<MASSalaryCalculation.Models.Employee> GetEmployee(String id)
        {
            return employees.FindAll(e => e.Id.Equals(id));
        }

    }
}
