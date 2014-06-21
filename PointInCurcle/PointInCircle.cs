using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInCurcle
{
    class PointInCircle
    {
        static void Main()
        {
            Console.WriteLine("Please intput coordinates X: ");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Please intput coordinates Y: ");
            double y = double.Parse(Console.ReadLine());

            if (x*x + y*y <= 4)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
