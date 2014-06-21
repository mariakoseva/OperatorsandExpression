using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractBitFromInteger
{
    class ExtractBitFromInteger
    {
        static void Main()
        {
            Console.WriteLine("Please enter the number that will be checked");
            int number = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());

            int mask = 1 << position;
            int bit = number & mask;
            bool isOne = bit == 1;

            Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));
            Console.WriteLine("Bit of position {0} is '1' = {1}", position, isOne);
        }
    }
}

  