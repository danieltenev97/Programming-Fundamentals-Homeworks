using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreas
{
    class Program
    {
        static void TriangleArea()
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double c = (a * h) / 2;
            Console.WriteLine($"{c:F2}");
        }
        static void RectangleArea()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double c = a * b;
            Console.WriteLine($"{c:F2}");
        }

        static void SquareArea()
        {
            double a = double.Parse(Console.ReadLine());


            double c = a * a;
            Console.WriteLine($"{c:F2}");
        }

        static void CircleArea()
        {
            double r = double.Parse(Console.ReadLine());
            

            double c = (r*r) *Math.PI;
            Console.WriteLine($"{c:F2}");
        }

        static void Main(string[] args)
        {
            string figuretype = Console.ReadLine();

            if(figuretype.Equals("triangle"))
            {
                TriangleArea();
            }
         else  if (figuretype.Equals("rectangle"))
            {
                RectangleArea();
            }
            else if (figuretype.Equals("square"))
            {
                SquareArea();
            }
            else
            {
                CircleArea();
            }



        }
    }
}
