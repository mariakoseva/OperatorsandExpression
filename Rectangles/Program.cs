using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangles
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The program calculates the Area and Perimeter of rectangle");
            double width = int.Parse(Console.ReadLine());
            double height = int.Parse(Console.ReadLine());

            double area = width * height;
            double perimeter = 2 * (width + height);

            Console.WriteLine("The area of the rectagle is: {0}", area);
            Console.WriteLine("The Perimeter of the rectagle is: {0}", perimeter);
        }
    }
}
