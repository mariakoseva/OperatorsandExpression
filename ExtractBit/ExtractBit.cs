using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ExtractBit
{
    static void Main()
    {
        Console.WriteLine("Please enter the number that will be checked");
        int number = int.Parse(Console.ReadLine());

        int mask = 1 << 3;
        int bit = number & mask;

        if (bit == 0)
        {
            Console.WriteLine("The third bit is zero " + Convert.ToString(number,2).PadLeft(16,'0'));
        }
        else
        {
            Console.WriteLine("The third bit is oneP: " + Convert.ToString(number,2).PadLeft(16,'0'));
        }

    }
}
