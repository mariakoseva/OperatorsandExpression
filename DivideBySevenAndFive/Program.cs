using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideBySevenAndFive
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The program calculates if number can be divided by 7 & 5 at the same time");
            int number = int.Parse(Console.ReadLine());

            bool divide = false;
            if (number % 35 ==0)
	            {
                    divide = true;
		            Console.WriteLine(divide);
	            }
            else
	            {
                    divide = false;
                    Console.WriteLine(divide);
	            }
            Console.ReadLine();
        }
    }
}
