using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdDigitIsSeven
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The program shows if the third digit of number is 7");
           int number = int.Parse(Console.ReadLine());
           int check = number % 1000;

           if (check == 7)
           {
               Console.WriteLine("The number is seven");
           }
           else
           {
               Console.WriteLine("The number is not seven");
           }
        }
    }
}

