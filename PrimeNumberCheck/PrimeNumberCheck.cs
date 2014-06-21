using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = CheckPrime(number);
            if (number <= 100)
            {
                if (result == 0)
            {
                Console.WriteLine("True");
            }
            else if (result == 1)
            {
                Console.WriteLine("FAlse");
            }
            else
            {
                Console.WriteLine("FAlse");
            }
            Console.Read(); 
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
        private static int CheckPrime(int number)
        {
            int i;
            for (i = 2; i <= number - 1; i++)
            {
                if (number % i == 0)
                {
                    return 0;
                }
            }
            if (i == number)
            {
                return 1;
            }
            return 0;
        }
    }
}