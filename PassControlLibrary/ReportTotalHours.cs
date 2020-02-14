using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassControlLibrary
{
    public class ReportTotalHours
    {
        public string NameSurname { get; private set; }
        public string TotalHours { get; private set; }

        public ReportTotalHours(string nameSurname, int totalHours)
        {
            NameSurname = nameSurname;
            TotalHours = Convert.ToString(totalHours);
        }
    }
}
