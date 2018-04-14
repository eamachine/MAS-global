using MASSalaryCalculation.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MASSalaryCalculation.Repository
{
    interface IEmployeeRepository
    {
        Task<List<Employee>> GetAsync();
    }
}
