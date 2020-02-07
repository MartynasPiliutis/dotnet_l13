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
            GateList.Add(new Gate(31, "North Pass"));
            GateList.Add(new Gate(32, "East Pass"));
            GateList.Add(new Gate(33, "South Pass"));
            GateList.Add(new Gate(34, "West Pass"));
        }

        public List<Gate> GetGateList()
        {
            return GateList;
        }

        public string GetGateCodeByID(int gateId)
        {
            foreach (var item in GateList)
            {
                if (gateId == item.GateId)
                {
                    return item.GateCode;
                }
            }
            return null;
        }
    }
}
