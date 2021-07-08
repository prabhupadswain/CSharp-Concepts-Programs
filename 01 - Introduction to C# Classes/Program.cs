using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCSharpClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Object is created nand parametrized constructor is called
            Employee e1 = new Employee("E01","John","Doe","Random Company Pvt.Ltd.");
            e1.PrintEmployeeDetails();

            Console.WriteLine("-----------------------------------------------------------------------------------");

            //Object is creted and default constructor called
            Employee e2 = new Employee();
            e2.PrintEmployeeDetails();

            Console.ReadLine();
        }
    }
}
