﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEvenNumber
{
    class OddOrEvenNumber
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            if (n % 2 ==0 )
            {
                Console.WriteLine("The number is even ");
            }
            else if (n % 2 !=0)
            {
                Console.WriteLine("The number is odd");
            }
            else
            {
                Console.WriteLine("The number is Zero");
            }
        }
    }
}
