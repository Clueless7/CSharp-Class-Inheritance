using System.Collections.Generic;

namespace ClassInheritance
{
    abstract class Department
    {
        public Person departmentHead;
        public List<Person> employees = new List<Person>();

        public void AddEmployee(Person person)
        {
            employees.Add(person);
        }

        public abstract void GetInfo();
        

        public Department(Person departmentHead)
        {
            this.departmentHead = departmentHead;
        }
    }
}
