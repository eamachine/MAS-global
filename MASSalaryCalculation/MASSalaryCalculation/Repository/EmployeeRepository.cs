using MASSalaryCalculation.DTOs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace MASSalaryCalculation.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        HttpClient _client = new HttpClient();

        public EmployeeRepository()
        {
            _client.BaseAddress = new Uri("http://masglobaltestapi.azurewebsites.net/");
            _client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<Employee>> GetAsync()
        {
            await Task.Delay(1000);
            
            HttpResponseMessage response = await _client.GetAsync("api/Employees");
            if (response.IsSuccessStatusCode)
            {
                var stringResult = await response.Content.ReadAsStringAsync();
                var employees = JsonConvert.DeserializeObject<List<Employee>>(stringResult);
                return employees;
            }
            return new List<Employee>();
        }
    }
}
