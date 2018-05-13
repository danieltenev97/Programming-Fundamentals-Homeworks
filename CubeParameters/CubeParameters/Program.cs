using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeParameters
{
    class Program
    {
        private static double CalculateFaceDigonals(double a)
        {
            double result = a * a + a * a;

            result = Math.Sqrt(result);
            

            return result;
        }

        private static double CalculateSpaceDiagonals(double b)
        {

            double result = (b * b) * 3;
            result = Math.Sqrt(result);

            return result;

        }

        private static double CalculateVolume(double c)
        {
            double result = Math.Pow(c, 3);

            return result;
        }

        private static double CalculateArea(double d)
        {
            double result = Math.Pow(d, 2);

            return result*6;
        }

        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());

            string type = Console.ReadLine();

            double result = 0;

            if(type.Equals("face"))
            {
                result = CalculateFaceDigonals(side);
                Console.WriteLine($"{result:F2}");
            }

            else if(type.Equals("space"))
            {
                result = CalculateSpaceDiagonals(side);
                Console.WriteLine($"{result:F2}");
            }
            else if(type.Equals("volume"))
            {
                result = CalculateVolume(side);
                Console.WriteLine($"{result:F2}");
            }

            else
            {
                result = CalculateArea(side);
                Console.WriteLine($"{result:F2}");
            }


        }
    }
}
