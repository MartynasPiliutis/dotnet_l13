using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PassControlLibrary;

namespace PassControlTest
{
    [TestClass]
    public class EventControllerTest
    {
        [TestMethod]
        public void TestuojameArGrazinaTeisingasReiksmesTryPassMetodas()
        {
            EventController eventController = new EventController();
            bool employeePassTrue = eventController.TryPass(2011, 31);
            bool employeePassFalse = eventController.TryPass(2012, 31);
            Assert.IsTrue(employeePassTrue);
            Assert.IsFalse(employeePassFalse);
        }
    }
}
