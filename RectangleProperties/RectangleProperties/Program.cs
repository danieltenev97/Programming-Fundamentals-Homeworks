﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double area = a * b;
            double perimeter = (a + b) * 2;
            double diagonal = a * a + b * b;

            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(Math.Sqrt(diagonal));

        }
    }
}
