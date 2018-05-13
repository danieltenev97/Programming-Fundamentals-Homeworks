using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmasthree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int i=0;i<=n;i++)
            {
                if(i==0)
                {
                    Console.Write(new string(' ',n+1));
                    Console.Write("|");
                    Console.Write(new string(' ', n+1));

                }

                else
                {
                    Console.Write(new string(' ', n-i));
                    for(int j=1;j<=i;j++)
                    {
                        Console.Write("*");
                    }
                    Console.Write(" ");
                    Console.Write("|");
                    Console.Write(" ");
                    for (int k = 1; k <= i; k++)
                    {
                        Console.Write("*");
                    }
                    Console.Write(new string(' ', n - i));
                }
                Console.WriteLine();
            }

        }
    }
}
