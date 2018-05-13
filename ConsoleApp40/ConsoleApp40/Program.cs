using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n * 2 - 1; i++)
            {
                if (i <= n)
                {
                    Console.Write(new string(' ', n - i));
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.Write(new string(' ', n - i));

                }
                else
                {
                    Console.Write(new string(' ',i-n));
                    for (int j = n-1; j >=i-n; j--)
                    {
                        Console.Write("* ");
                    }
                    Console.Write(new string(' ', i - n));




                }
                Console.WriteLine();
            }
        }
    }
}
