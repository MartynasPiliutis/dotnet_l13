using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PassControlLibrary;

namespace PassControlTest
{
    [TestClass]
    public class EmployeeRepositoryTest
    {
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
