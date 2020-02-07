using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassControlLibrary
{
    public class Employee
    {
        public int EmployeeId { get; private set; }
        public string NameSurname { get; set; }
        private List<int> PassRights;

        public Employee(int employeeid, string namesurname, List<int> passrights)
        {
            EmployeeId = employeeid;
            NameSurname = namesurname;
            PassRights = passrights;
        }
    }
}
