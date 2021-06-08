using System;
using System.Collections.Generic;

namespace ClassInheritance
{
    class ITDepartment : Department
    {
        public List<Person> administrators = new List<Person>();

        public override void GetInfo()
        {
            Console.WriteLine("==========IT Department Information==========");
            Console.WriteLine();
            Console.WriteLine($"Department Head: {departmentHead.name}");
            Console.WriteLine();
            Console.WriteLine("Employees: ");
            foreach (Person employee in employees)
            {
                Console.WriteLine(employee.name);
            }
            Console.WriteLine();
            Console.WriteLine("Admins ");
            foreach (Person admin in administrators)
            {
                Console.WriteLine(admin.name);
            }
        }

        public ITDepartment(Person departmentHead, List<Person> admins): base(departmentHead)
        {
            administrators.AddRange(admins);
        }
    }
}
