using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassControlLibrary
{
    public class Gate
    {
        public int GateId { get; private set; }
        public string GateCode { get; set; }

        public Gate(int gateid, string gatecode)
        {
            GateId = gateid;
            GateCode = gatecode;
        }
    }
}
