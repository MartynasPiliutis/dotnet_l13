using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassControlLibrary
{
    public class GateRepository
    {
        private List<Gate> GateList;

        public GateRepository()
        {
            GateList = new List<Gate>();
            GateList.Add(new Gate(1001, "North Pass"));
            GateList.Add(new Gate(1002, "East Pass"));
            GateList.Add(new Gate(1003, "South Pass"));
            GateList.Add(new Gate(1004, "West Pass"));
        }
    }
}
