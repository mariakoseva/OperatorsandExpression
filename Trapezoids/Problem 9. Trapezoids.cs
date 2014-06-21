using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapezoids
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The program calculates the are of trapezoid");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

		         double area = ((a + b) * h) / 2;
                 Console.WriteLine("The are is {0}", area);
        }
    }
}
