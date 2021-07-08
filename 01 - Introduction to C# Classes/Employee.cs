using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCSharpClasses
{
    class Employee
    {
        //Class fields of Employee class
        string employeeId;
        string firstName;
        string lastName;
        string companyName;

        public Employee()
        {
            this.employeeId = "DE01";
            this.firstName = "Harry";
            this.lastName = "Brown";
            this.companyName = "Default Company";
        }

        //Parameterized Constructor
        public Employee(string employeeId, string firstName, string lastName, string companyName)
        {
            this.employeeId = employeeId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.companyName = companyName;
        }

        //Methods
        public void PrintEmployeeDetails()
        {
            Console.WriteLine("Employee ID: {0}", this.employeeId);
            Console.WriteLine("Employee Fullname: {0} is working at company: {1}", this.firstName + ' ' + this.lastName, this.companyName);
        }

    }
}
