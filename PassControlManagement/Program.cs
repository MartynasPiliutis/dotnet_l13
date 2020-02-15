using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PassControlLibrary;
using System.Threading;

namespace PassControlManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int darbuotojoId;
            int vartuNr;
            int pauze;

            EmployeeRepository employeeRepository = new EmployeeRepository();
            GateRepository gateRepository = new GateRepository();
            List<Event> EventList = new List<Event>();

            List<Employee> EmployeeList = employeeRepository.GetEmployeeList();
            List<Gate> GateList = gateRepository.GetGateList();
            EventController eventController = new EventController(employeeRepository);

            foreach (var item in EmployeeList)
            {
                Console.WriteLine($"{item.EmployeeId} {item.NameSurname}");
            }

            Console.WriteLine("Pradedam");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine( $"{i}");
                darbuotojoId = rnd.Next(2001, 2020);

                vartuNr = rnd.Next(1,4);

                pauze = rnd.Next(100, 10000);
                Console.WriteLine($"{darbuotojoId} {vartuNr} {pauze}");

                EventList = eventController.SaveTryPass(darbuotojoId, vartuNr);
                Thread.Sleep(pauze);
            }
            Console.WriteLine("Pass");

            foreach (var item in EventList)
            {
                Console.WriteLine($"{item.EventId} {item.EmployeeId} {item.GateId} {item.PassTime} {item.Pass}");
            }

            Console.WriteLine("Pass1");

            ReportGenerator reportGenerator = new ReportGenerator(employeeRepository, gateRepository, EventList);
            List<ReportEvent> reportEvents = reportGenerator.GanerateAllEventsReport();
            List<ReportTotalHours> reportTotalHours = reportGenerator.GenerateTotalHoursReport();

            Console.WriteLine("Pass2");

            foreach (var item in reportEvents)
            {
                Console.WriteLine($"{item.NameSurname} {item.GateName} {item.DatePass} {item.PassControl}");
            }

            Console.WriteLine("Pass3");

            foreach (var item in reportTotalHours)
            {
                Console.WriteLine($"{item.NameSurname} {item.TotalHours}");
            }
            Console.ReadLine();
        }
    }
}
