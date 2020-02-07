using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassControlLibrary
{
    class Event
    {
        public int EventId { get; private set; }
        public int EmployeeId { get; private set; }
        public int GateId { get; private set; }
        public DateTime PassTime { get; private set; }
        public bool Pass { get; private set; }

        public Event(int eventid, int employeeid, int gateid, DateTime passtime, bool pass)
        {
            EventId = eventid;
            EmployeeId = employeeid;
            GateId = gateid;
            PassTime = passtime;
            Pass = pass;
        }
    }
}
