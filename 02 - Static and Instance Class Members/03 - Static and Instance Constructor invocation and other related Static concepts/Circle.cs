using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndInstanceConstructor
{
    class Circle
    {
        public static float PI;
        int radius;

        static Circle()
        {
            Console.WriteLine("Static Constructor called");
            Circle.PI = 3.14f;
        }

        public Circle(int radius)
        {
            Console.WriteLine("Instance Constructor called");
            this.radius = radius;
        }

        public float CalculateArea()
        {
            return Circle.PI * this.radius * radius;
        }
    }
}
