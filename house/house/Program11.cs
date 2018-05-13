using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace house
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int midn = n / 2;
            midn++;

            int stars = 1;

            
             for (int i = 1; i <= n; i++)
            {
                if (n % 2 == 0)
                {
                    if (i == 1)
                    {
                        Console.WriteLine("{0}**{0}", new string('-', (n - i) / 2));
                    }
                    else if (i < midn - 1)
                    {
                        Console.WriteLine("{0}{1}{0}", new string('-', n / 2 - i), new string('*', i * 2), new string('-', n / 2 - i));
                    }
                    else if (i == midn - 1)
                    {
                        Console.WriteLine(new string('*', n));
                    }
                    else
                    {
                        Console.WriteLine("|{0}|", new string('*', n - 2));
                    }
                }

                else
                {
                   
                     if (i < midn)
                    {

                       
                    Console.WriteLine("{0}{1}{0}", new string('-', (n - stars) / 2), new string('*', stars), new string('-', (n - stars) / 2));
                        stars += 2;    

                    }
                    else if (i == midn)
                    {
                        Console.WriteLine(new string('*', n));
                    }
                    else
                    {
                        Console.WriteLine("|{0}|", new string('*', n - 2));
                    }
                }
            }

        }
    }
}
