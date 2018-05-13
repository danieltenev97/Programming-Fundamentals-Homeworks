using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConversion
{
    class Program
    {
       static double Convert(double fahrenheit)
        {
            fahrenheit = (fahrenheit - 32) * 5 / 9;

            return fahrenheit;
        }

        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());

            double result = Convert(a);
            Console.WriteLine($"{result:F2}");
               

        }
    }
}
