using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceEmployeeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee fte = new FullTimeEmployee();

            //Access to base class field members
            fte.firstName = "Rohit";
            fte.lastName = "Verma";

            //Access to derived class field members
            fte.yearlySal = 50000;
            
            //Access to base class method
            fte.PrintFullName();

            //Access to derived class field members
            Console.WriteLine("Full Time Employee salary: {0}", fte.yearlySal);

            Console.WriteLine("--------------------------------------------------------------------------------------");

            PartTimeEmployee pte = new PartTimeEmployee();
            
            //Access to base class members
            pte.firstName = "Virat";
            pte.lastName = "Rahane";

            //Access to derived class members
            pte.hourlyRate = 1000;

            //Access to base class method
            pte.PrintFullName();

            //Access to derived class field members
            Console.WriteLine("Part Time Employee salary: {0}", pte.hourlyRate);

            Console.ReadLine();

        }
    }
}
