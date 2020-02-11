using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PassControlLibrary;
using System.Collections.Generic;


namespace PassControlTest
{
    [TestClass]
    public class ReportGeneratorTests
    {
        [TestMethod]
        public void PatikrinameArReportEventsGrazinaTeisingusDuomenis()
        {
            EmployeeRepository employeeRepository = new EmployeeRepository();
            GateRepository gateRepository = new GateRepository();
            List<Event> EventList = new List<Event>();
            EventList.Add(new Event(123456, 2020, 34, DateTime.Now, true));
            EventList.Add(new Event(654321, 2010, 34, DateTime.Now, false));
            ReportGenerator reportGenerator = new ReportGenerator(employeeRepository, gateRepository, EventList);
            List<ReportEvent> reportEvents = reportGenerator.GanerateAllEventsRport();
            int reportEventsCount = reportEvents.Count;

            string userPassName = reportEvents[0].NameSurname;
            string userPassGate = reportEvents[0].GateName ;
            string userPassPass = reportEvents[0].PassControl ;

            string userFailName = reportEvents[1].NameSurname;
            string userFailGate = reportEvents[1].GateName;
            string userFailPass = reportEvents[1].PassControl;

            Assert.AreEqual(reportEventsCount, 2);
            Assert.AreEqual(userPassName, "Deimante Klimiene");
            Assert.AreEqual(userPassGate, "West Pass");
            Assert.AreEqual(userPassPass, "Success");

            Assert.AreEqual(userFailName, "Ruta Siaule");
            Assert.AreEqual(userFailGate, "West Pass");
            Assert.AreEqual(userFailPass, "Denied");
        }
    }
}
