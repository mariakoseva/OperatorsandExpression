using System;

namespace FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter your four-digit number:");
            string digit = Console.ReadLine();

            if (digit.Length != 4)
            {
                Console.WriteLine("Please write a number from 999 to 9999");
            }
            else
            {
                int a = (int)char.GetNumericValue(digit[0]);
                int b = (int)char.GetNumericValue(digit[1]);
                int c = (int)char.GetNumericValue(digit[2]);
                int d = (int)char.GetNumericValue(digit[3]);

                // Sum of the digits
                Console.WriteLine("Sum of the digits:");
                Console.WriteLine(a + b + c + d);

                //Reversed position
                Console.WriteLine("Your number in reversed order:");
                Console.WriteLine("{0}{1}{2}{3}", d, c, b, a);

                //Switching positions of last and first digits
                Console.WriteLine("Last digit in the first position");
                Console.WriteLine("{0}{1}{2}{3}", d, a, b, c);
                // Exchanged second and third digits
                Console.WriteLine("Exchanged second and third digit:");
                Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);
            }
        }
    }
}