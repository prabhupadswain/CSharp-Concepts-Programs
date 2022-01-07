using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class YourNameAndAge
    {
        public void PrintYourName_Age(string name, byte age)
        {
            Console.WriteLine("Method called with string 1st argument and byte second argument");
            Console.WriteLine("Hello, my name is " + name + ".I am " + age + " years old.");
            Console.Write("\n");
        }

        public void PrintYourName_Age(byte age, string name)
        {
            Console.WriteLine("Method called with byte as 1st argument and string second argument");
            Console.WriteLine("Hello, my name is " + name + ".I am " + age + " years old.");
            Console.Write("\n");
        }

    }
}
