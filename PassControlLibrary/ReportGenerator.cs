using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassControlLibrary
{
    public class ReportGenerator
    {
        private EmployeeRepository employeeRepository;
        private GateRepository gateRepository;
        public List<Event> EventList;

        public ReportGenerator(EmployeeRepository employeeRepository, GateRepository gateRepository, List<Event> eventList)
        {
            this.employeeRepository = employeeRepository;
            this.gateRepository = gateRepository;
            EventList = eventList;
        }

        public List<ReportEvent> GanerateAllEventsRport()
        {
            List<ReportEvent> reportEvents = new List<ReportEvent>();
            foreach (var oneEvent in EventList)
            {
                string name = employeeRepository.GetEmployeeById(oneEvent.EmployeeId).NameSurname;
                string gateName = gateRepository.GetGateCodeByID(oneEvent.GateId);
                ReportEvent reportEvent = new ReportEvent(name, gateName, oneEvent.PassTime, oneEvent.Pass);
                reportEvents.Add(reportEvent);
            }
            return reportEvents;
        }
    }
}
