using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassControlLibrary
{
    public class EventController
    {
            //DEPENDENCY INJECTION START
        private EmployeeRepository employeeRepository;
        public EventController(EmployeeRepository emploRepo)
        {
            this.employeeRepository = emploRepo;
        }
            //DEPENDENCY INJECTION START

        List<Event> EventList = new List<Event>();
        public bool TryPass(int employeeId, int gateIdPass)
        {
            Employee employee = employeeRepository.GetEmployeeById(employeeId);
            bool employeePass;
            int employeeIdFind = employee.EmployeeId;
            employeePass = employee.CheckEmployeeHasRight(gateIdPass);
            EventList.Add(new Event(GetNewEventId(), employeeId, gateIdPass, GetNewEventPassTime(), employeePass));
            return employeePass;
        }

        public long GetNewEventId()
        {
            return Convert.ToInt64($"{DateTime.Now.Year}{DateTime.Now.Month}{DateTime.Now.Day}{DateTime.Now.Hour}{DateTime.Now.Minute}{DateTime.Now.Second}{DateTime.Now.Millisecond}");
        }

        public DateTime GetNewEventPassTime()
        {
            return DateTime.Now;
        }
    }
}
