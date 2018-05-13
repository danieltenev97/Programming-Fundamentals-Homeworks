using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongerLine
{
    class Program
    {
        private static void Compare(decimal x,decimal y, decimal x1, decimal y1, decimal x2, decimal y2, decimal x3, decimal y3)
        {
            if (Math.Max(x, x1) - Math.Min(x, x1) >= Math.Max(x2, x3) - Math.Min(x2, x3)&& Math.Max(y, y1) - Math.Min(y, y1) >= Math.Max(y2, y3) - Math.Min(y2, y3))
            {
                decimal ab = x * x + y * y;
                decimal cd = x1 * x1 + y1 * y1;

                if (ab <= cd)
                {
                    Console.WriteLine($"({x}, {y})({x1}, {y1})");
                }

                else
                {
                    Console.WriteLine($"({x1}, {y1})({x}, {y})");
                }
            }
            else
            {
                decimal ab = x2 * x2 + y2 * y2;
                decimal cd = x3 * x3 + y3 * y3;

                if (ab <= cd)
                {
                    Console.WriteLine($"({x2}, {y2})({x3}, {y3})");
                }

                else
                {
                    Console.WriteLine($"({x3}, {y3})({x2}, {y2})");
                }

            }
        }

        static void Main(string[] args)
        {
            decimal x = decimal.Parse(Console.ReadLine());
            decimal y = decimal.Parse(Console.ReadLine());
            decimal x1 = decimal.Parse(Console.ReadLine());
            decimal y1 = decimal.Parse(Console.ReadLine());
            decimal x2 = decimal.Parse(Console.ReadLine());
            decimal y2 = decimal.Parse(Console.ReadLine());
            decimal x3 = decimal.Parse(Console.ReadLine());

            decimal y3 = decimal.Parse(Console.ReadLine());


            Compare(x, y, x1, y1, x2, y2, x3, y3);
                


        }
    }
}
