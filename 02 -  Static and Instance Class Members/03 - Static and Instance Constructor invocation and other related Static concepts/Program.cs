using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndInstanceConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(5);
            float area1 = c1.CalculateArea();
            Console.WriteLine("Circle One area: {0}", area1);

            Console.WriteLine("--------------------------------------------------------------------------");

            Circle c2 = new Circle(6);
            float area2 = c2.CalculateArea();
            Console.WriteLine("Circle Two area: {0}", area2);

            Console.WriteLine("--------------------------------------------------------------------------");

            Circle c3 = new Circle(7);
            float area3 = c3.CalculateArea();
            Console.WriteLine("Circle Three area: {0}", area3);

            Console.ReadLine();
        }
    }
}
