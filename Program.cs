using System;
using System.Collections.Generic;

namespace ClassInheritance
{
    class Program
    {
        // Dummy data for accounting dept
        static Person acctHead = new Person(20, "John Doe");
        static Person acctEmployee2 = new Person(25, "Max Imus");
        static Person acctEmployee1 = new Person(43, "Foo Bar");
        static Person acctEmployee3 = new Person(53, "Lorem Ipsum");


        // Dummy data for IT dept
        static Person ITHead = new Person(23, "Hacker Man");
        public static List<Person> ITAdmins = new List<Person>();
        static Person ITAdmin1 = new Person(99, "Omega Lul");
        static Person ITAdmin2 = new Person(36, "Pog O");
        static Person ITEmployee1 = new Person(36, "Max Imus");
        static Person ITEmployee2 = new Person(27, "Foo Bar");
        static Person ITEmployee3 = new Person(53, "Lorem Ipsum");
        static void Main(string[] args)
        {
            AccountingDepartment accountingDepartment = new AccountingDepartment(acctHead, new List<string>() { "report#1", "report#2" });
            accountingDepartment.AddEmployee(acctEmployee1);
            accountingDepartment.AddEmployee(acctEmployee2);
            accountingDepartment.AddEmployee(acctEmployee3);
            accountingDepartment.GetInfo();

            ITAdmins.Add(ITAdmin1);
            ITAdmins.Add(ITAdmin2);

            ITDepartment iTDepartment = new ITDepartment(ITHead, ITAdmins);
            iTDepartment.AddEmployee(ITEmployee1);
            iTDepartment.AddEmployee(ITEmployee2);
            iTDepartment.AddEmployee(ITEmployee3);
            iTDepartment.GetInfo();
        }
    }
}
