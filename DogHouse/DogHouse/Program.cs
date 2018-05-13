using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogHouse
{
    class Program
    {
        static void Main(string[] args)
        {

            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());

            
            double c = A / 2;
            double d = A / 5;
            double z = B - c;

            double stenaArea = (A * c)*2;
            double zadnastenaArea = c * c + (c * z) / 2;
            double prednaArea = c * c - d * d +(c*z)/2;

            double pokrivpaint = stenaArea / 5;
            double stenapaint = (stenaArea + zadnastenaArea+prednaArea) / 3;

            Console.WriteLine($"{stenapaint:F2}");
            Console.WriteLine($"{pokrivpaint:F2}");
           



        }
    }
}
