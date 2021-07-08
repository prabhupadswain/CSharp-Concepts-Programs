using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceEmployeeExample
{
    //Base class
    public class Employee
    {
        public string firstName;
        public string lastName;

        public void PrintFullName()
        {
            Console.WriteLine("Name of employee: {0}", firstName + " " +lastName);
        }
    }

    //Inheriting Classes
    public class FullTimeEmployee : Employee
    {
        public float yearlySal;
    }

    public class PartTimeEmployee : Employee
    {
        public float hourlyRate;
    }
}
