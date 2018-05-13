using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            Console.Write($"{a:D4} ");
            Console.Write($"{b:D4} ");
            Console.Write($"{c:D4} ");
            Console.Write($"{d:D4}");
        }
    }
}
