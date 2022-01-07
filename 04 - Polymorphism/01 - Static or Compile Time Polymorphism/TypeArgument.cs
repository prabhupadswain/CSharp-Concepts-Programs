using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class TypeArgument
    {
        public void checkType(int value)
        {
            Console.WriteLine("Method called with integer value");
            Console.WriteLine("Value : {0} ", value);
            Console.Write("\n");
        }

        public void checkType(float value)
        {
            Console.WriteLine("Method called with floating value");
            Console.WriteLine("Value : {0}", value);
            Console.Write("\n");
        }

        public void checkType(string value)
        {
            Console.WriteLine("Method called with string value");
            Console.WriteLine("Value : {0}", value);
            Console.Write("\n");
        }
    }
}
