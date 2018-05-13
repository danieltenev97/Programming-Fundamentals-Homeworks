using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleArea
{
    class Program
    {
        static double CalculateArea(double c,double d)

        {
            double result = (c * d) / 2;
            return result;
        }

        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double result = CalculateArea(a, b);
            Console.WriteLine($"{result}");



        }
    }
}
