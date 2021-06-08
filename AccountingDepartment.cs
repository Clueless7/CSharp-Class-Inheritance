using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritance
{
    class AccountingDepartment : Department
    {
        public List<string> accountingReports = new List<string>();

        public override void GetInfo()
        {
            Console.WriteLine("==========Accounting Department Information==========");
            Console.WriteLine();
            Console.WriteLine($"Department Head: {departmentHead.name}");
            Console.WriteLine();
            Console.WriteLine("Employees: ");
            foreach (Person employee in employees)
            {
                Console.WriteLine(employee.name);
            }
            Console.WriteLine();
            Console.WriteLine("Reports: ");
            foreach (string report in accountingReports)
            {
                Console.WriteLine(report);
            }
        }

        public AccountingDepartment(Person departmentHead, List<string> reports): base(departmentHead)
        {
            accountingReports.AddRange(reports);
        }

    }
}
