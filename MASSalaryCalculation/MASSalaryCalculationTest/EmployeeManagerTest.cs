using MASSalaryCalculation.BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MASSalaryCalculationTest
{
    [TestClass]
    public class EmployeeManagerTest
    {
        EmployeeManager employeeManager;

        public EmployeeManagerTest()
        {
            employeeManager = new EmployeeManager();
        }

        [TestMethod]
        public void GetUnkonwIdEmployee()
        {
            var employees = employeeManager.GetEmployee("3");

            Assert.IsTrue(employees.Count == 0);

        }

        [TestMethod]
        public void GetEmployeeFilltered()
        {
            var employees = employeeManager.GetEmployee("1");

            Assert.AreEqual(employees[0].Id, "1");

        }

        [TestMethod]
        public void GetEmployees()
        {
            var employees = employeeManager.GetEmployees();

            Assert.IsNotNull(employees);

        }
    }
}
