using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp58
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a=0;
            int b = 0;
            int c = 0;
            int d = 0;
            int number = 0;
            int v = 0;
            int g = 0;
            for (int i = 1000; i <10000; i++)
            {
                a = i / 1000;
                b = (i / 100)%10;
                c = (i / 10) % 10;
                d = (i % 1000)%10;
                if (d == 0) continue;
                if(((a<b)&&(c>d))&&(a*b+c*d==n))
                {
                    number = i;
                    v++;
                    if(v==4)
                    {
                        g = i;
                    }
                  
                    Console.Write(number + " ");
               
                }

            }
            Console.WriteLine();
            if(v<4)
            {
                Console.WriteLine("No!");
            }

            else
            {
                Console.WriteLine($"Password: {g}");
            }

        }
    }
}
