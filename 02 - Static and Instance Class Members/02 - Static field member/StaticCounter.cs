using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherExampleOfStaticMembers
{
    class StaticCounter
    {
        public static int Count = 0;

        public StaticCounter()
        {
            Count++;
        }
    }
}
