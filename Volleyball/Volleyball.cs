using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main()
        {
            string leap = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            int weekInTheYear = 48;
            int NormalWeekEndCount = weekInTheYear - h;
            int playIntheHollidays = (2 * p) / 3;
            int playWhenHeIsNotAtWork = ((NormalWeekEndCount* 3)) / 4;

            if (leap == "normal" )    
            {
                int gamesVladoPlays = playIntheHollidays + playWhenHeIsNotAtWork + h ;
                Console.WriteLine( gamesVladoPlays);
            }
            else
            {
                int gamesVladoPlays = playIntheHollidays + playWhenHeIsNotAtWork + h;
                double gamesVladoPlaysinNormalYear = 1.15 * gamesVladoPlays;
                Console.WriteLine((int)gamesVladoPlaysinNormalYear);
            }
          

        }
    }
}
