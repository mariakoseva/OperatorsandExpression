using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GravitationOnTheMoon
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The program calculates th e human weight on the moon");
            int weight = int.Parse(Console.ReadLine());

            double percerntGravitation = 0.17;
            double humanWeightOnTheMoon = weight * percerntGravitation;
            Console.WriteLine(humanWeightOnTheMoon);

        }
    }
}
