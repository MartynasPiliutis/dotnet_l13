using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PassControlLibrary;

namespace PassControlTest
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void TikrinameArDarbuotojasTuriTeisePraeitiTamtikrusVartus()
        {
            //assign
            EmployeeRepository employeeRepository = new EmployeeRepository();
            //act
            Employee checkEmployee = employeeRepository.GetEmployeeById(2011);
            bool employeePassTrue = checkEmployee.CheckEmployeeHasRight(31);
            bool employeePassFalse = checkEmployee.CheckEmployeeHasRight(34);
            //assert
            Assert.IsTrue(employeePassTrue);
            Assert.IsFalse(employeePassFalse);
        }
    }
}
