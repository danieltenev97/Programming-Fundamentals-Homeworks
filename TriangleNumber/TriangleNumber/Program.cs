using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            PrintNumber(a);


        }

        static void PrintNumber(int a)
        {
            for (int i = 1; i <=a; i++)
            {
                for (int j = 1; j <=i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }

            for (int i = a-1; i>=1; i--)
            {
                for (int j = 1; j <=i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }
    }
}
