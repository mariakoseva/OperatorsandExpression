using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main()
        {
            Console.WriteLine("Please input a number");
            int number = int.Parse(Console.ReadLine());

            if (number > 999)
            {
                int numberThousand = number/1000;
                    Console.WriteLine("The numTH = {0}", numberThousand);
                int numberHundreds = (number / 100) % 10;
                Console.WriteLine("The numberHundreds = {0}", numberHundreds);
                int numberTens = (number / 10) % 10;
                Console.WriteLine("numberTens = {0}", numberTens);
                int numberOnes = (number) % 10;
                Console.WriteLine("numberOnes= {0}", numberOnes);
                int sum = numberThousand + numberHundreds + numberTens + numberOnes;
                Console.WriteLine("The sum  a + b + c + d = {0}", sum);   //sum of the digits
                Console.WriteLine("The number in reversed order: {3}{2}{1}{0}", numberThousand, numberHundreds, numberTens, numberOnes);    //the number in reversed order
                Console.WriteLine("The number with last digit on first position is:{0}{1}{2}{3}", numberOnes, numberThousand, numberHundreds, numberTens);   //the number with last digit on first position
                Console.WriteLine("The number with exchanges second and third position is {}{}{}{}", numberThousand, numberTens, numberHundreds, numberOnes); //number with exchanges second and third position
            }
            else
            {
                Console.WriteLine("Ivalid Input:\n Please write another number from 999 to 9999");
            }


           
        }
    }
}
