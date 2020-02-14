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

        public List<ReportEvent> GanerateAllEventsReport()
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

        public List<ReportTotalHours> GenerateTotalHoursREport()
        {
            List<ReportTotalHours> reportTotalHours = new List<ReportTotalHours>();
            for (int id = 2001; id <= 2020; id++)
            {
                int checkEmployeeId = id;
                List<ReportOnePass> reportOnePass = new List<ReportOnePass>();
                int totalHours = 0;
                foreach (var oneEvent in EventList)
                {
                    int employeeId = employeeRepository.GetEmployeeById(oneEvent.EmployeeId).EmployeeId;
                    if (oneEvent.Pass == true && employeeId == checkEmployeeId)
                    {
                        ReportOnePass onePass = new ReportOnePass(oneEvent.PassTime);
                        reportOnePass.Add(onePass);
                    }
                }
                for (int i = 1; i <= reportOnePass.Count - 1; i = i + 2)
                {
                    int j = i + 1;
                    DateTime passTimeIn = reportOnePass[i].OnePass;
                    DateTime passTimeOut = reportOnePass[j].OnePass;
                    TimeSpan timeIn = passTimeOut - passTimeIn;
                    totalHours = totalHours + Convert.ToInt32(timeIn);
                }
                string name = employeeRepository.GetEmployeeById(checkEmployeeId).NameSurname;
                reportTotalHours.Add(new ReportTotalHours(name, totalHours));
            }
            return reportTotalHours;
        }
    }
}
