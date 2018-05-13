using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp62
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int a = 1;
            Console.WriteLine(a);
            for (int i = 1; i <= n; i++)
            {
                a = 2 * a;
                if (i % 2 == 0)
                {
                   
                    Console.WriteLine(a);
                }
            }
        }
    }
}
