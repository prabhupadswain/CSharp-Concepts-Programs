using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstanceAndStaticMembers
{
    class Calculator
    {
        //Static Methods
        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Difference(int num1, int num2)
        {
            return num1 > num2 ? (num1 - num2) : (num2 - num1);
        }

        //Instance Methods
        public int Product(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Quotient(int num1, int num2)
        {
            return num1 > num2 ? (num1 / num2) : (num2 / num1);
        }
    }
}
