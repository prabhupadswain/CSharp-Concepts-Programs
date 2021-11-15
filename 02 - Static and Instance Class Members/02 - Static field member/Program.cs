using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherExampleOfStaticMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Static Variable/fields are common for all instance of a that class.
            Console.WriteLine("Count = {0}", StaticCounter.Count);

            StaticCounter sc1 = new StaticCounter();
            StaticCounter sc2 = new StaticCounter();
            Console.WriteLine("Count = {0}", StaticCounter.Count);

            StaticCounter sc3 = new StaticCounter();
            StaticCounter sc4 = new StaticCounter();
            Console.WriteLine("Count = {0}", StaticCounter.Count);

            Console.ReadLine();
        }
    }
}
