using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstanceAndStaticMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Static methods can be called using class name without creation of an class instance.
            Console.WriteLine("Static Methods");

            int sum = Calculator.Sum(3, 5);
            Console.WriteLine("Sum: {0}", sum);

            int difference = Calculator.Difference(2, 8);
            Console.WriteLine("Difference: {0}", difference);

            Console.WriteLine("-----------------------------------------------------------------------------");

            Console.WriteLine("Instance methods");
            Calculator c1 = new Calculator();

            //Instance methods has to be called using an instance of the class
            int product = c1.Product(10, 2);
            Console.WriteLine("Product: {0}", product);

            int quotient = c1.Quotient(15, 3);
            Console.WriteLine("Quotient: {0}", quotient);

            Console.ReadLine();
        }
    }
}
