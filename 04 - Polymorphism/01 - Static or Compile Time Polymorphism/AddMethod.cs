using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class AddMethod
    {
        //Add Method using two arguments
        public void Add(int x, int y)
        {
            Console.WriteLine("Add method called having two arguments");
            Console.WriteLine("Sum = " + (x + y));
            Console.Write("\n");
        }

        //Add method using three arguments
        public void Add (int x, int y, int z)
        {
            Console.WriteLine("Add method called having three arguments");
            Console.WriteLine("Sum = " + (x+y+z));
            Console.Write("\n");
        }
    }
}
