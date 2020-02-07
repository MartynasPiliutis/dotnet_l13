using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PassControlLibrary;

namespace PassControlTest
{
    [TestClass]
    public class EmployeeRepositoryTest
    {
        [TestMethod]
        public void TikrinameArGrazinaVisaDarbuotojuSarasa()
        {
            //Assing
            EmployeeRepository employeeRepository = new EmployeeRepository();
            //Act
            int employeeListCount = employeeRepository.GetEmployeeList().Count;
            //Assert
            Assert.AreEqual(employeeListCount, 20);
        }

        [TestMethod]
        public void TikrinameArSurandaDarbuotojaPagalEmployeeId()
        {
            //Assign
            EmployeeRepository employeeRepository = new EmployeeRepository();
            //Act
            int findEmployeeId = employeeRepository.GetEmployeeById(2011).EmployeeId;
            //Assert
            Assert.AreEqual(findEmployeeId, 2011);
        }
    }
}
