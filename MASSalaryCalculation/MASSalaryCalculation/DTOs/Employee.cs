using Newtonsoft.Json;
using System;

namespace MASSalaryCalculation.DTOs
{
    public class Employee
    {
        [JsonProperty("id")]
        public String Id { get; set; }
        [JsonProperty("name")]
        public String Name { get; set; }
        [JsonProperty("contractTypeName")]
        public String ContractTypeName { get; set; }
        [JsonProperty("roleId")]
        public String RoleId { get; set; }
        [JsonProperty("roleName")]
        public String RoleName { get; set; }
        [JsonProperty("roleDescription")]
        public String RoleDescription { get; set; }
        [JsonProperty("hourlySalary")]
        public double HourlySalary { get; set; }
        [JsonProperty("monthlySalary")]
        public double MonthlySalary { get; set; }
    }
}
