using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterPoint
{
    class Program
    {
        private static void Compare(double a, double b, double c, double d)
        {
            double ab = a * a + b * b;
            double cd = c * c + d * d;

            if(ab==cd)
            {
                Console.WriteLine($"({a}, {b})");
            }

            else
            {
                double min = Math.Min(ab, cd);

                if(min==ab)
                {
                    Console.WriteLine($"({a}, {b})");
                }
                
                else
                {
                    Console.WriteLine($"({c}, {d})");
                }
            }
        

        }

        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            Compare(x1, y1, x2, y2);

        }
    }
}
