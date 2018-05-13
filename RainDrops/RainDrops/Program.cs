using System;
using System.Linq;
using System.Collections.Generic;

namespace RainDrops
{
    class Program
    {
        static void Main(string[] args)
        {
            long region = long.Parse(Console.ReadLine());
            decimal dentisty = decimal.Parse(Console.ReadLine());
            decimal regionskoef = 0;
            for (int i = 0; i < region; i++)
            {
                var inputregions = Console.ReadLine().Split().Select(long.Parse).ToList();

                long raidropsCount = inputregions[0];
                long squareMeter = inputregions[1];
                decimal currentregion = (decimal)raidropsCount / (decimal)squareMeter;

                regionskoef += currentregion;

            }
            decimal result = 0;

            if (dentisty != 0)
            {
                result = regionskoef / dentisty;

                Console.WriteLine($"{result:f3}");
            }
            else
            {
                Console.WriteLine($"{regionskoef:f3}");
            }
        }
    }
}
