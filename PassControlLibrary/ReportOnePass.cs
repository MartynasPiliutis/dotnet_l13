using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassControlLibrary
{
    public class ReportOnePass
    {
        public DateTime OnePass { get; private set; }

        public ReportOnePass(DateTime onePass)
        {
            OnePass = onePass;
        }
    }
}
