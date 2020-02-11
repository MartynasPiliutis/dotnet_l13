using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassControlLibrary
{
    class ReportEvents
    {
        public string NameSurname { get; private set; }
        public string GateName { get; private set; }
        public string DatePass { get; private set; }
        public string PassControl { get; private set; }

        public ReportEvents(string nameSurname, string gateName, DateTime datePass, bool passControl)
        {
            NameSurname = nameSurname;
            GateName = gateName;
            DatePass = Convert.ToString(datePass);
            PassControl = GetPassControlResult(passControl);
        }

        public string GetPassControlResult(bool pass)
        {
            string passResult;
            if (pass == true)
            {
                passResult = "Success";
            }
            else passResult = "Denied";
            return passResult;
        }
    }
}
