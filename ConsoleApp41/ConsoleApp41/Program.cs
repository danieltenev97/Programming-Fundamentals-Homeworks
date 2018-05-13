using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double midn = n / 2.0;
           midn= Math.Ceiling(midn);

            
                for(int i=1;i<=n;i++)
            {
                if(n%2!=0)
                {
                    if (i == 1 || i == n)
                    {
                        Console.Write("{0}{1}{0}", new string('*', n * 2), new string(' ', n));
                    }
                    else if (i == midn)
                    {
                        char str = '*';
                        Console.Write("{0}{1}{0}{2}{0}{1}{0}", str, new string('/', (n * 2) - 2), new string('|', n));
                    }
                    else
                    {

                        char str = '*';
                        Console.Write("{0}{1}{0}{2}{0}{1}{0}", str, new string('/', (n * 2) - 2), new string(' ', n));
                    }
                }

                else
                {
                    if (i == 1 || i == n)
                    {
                        Console.Write("{0}{1}{0}", new string('*', n * 2), new string(' ', n));
                    }
                    else if (i == midn)
                    {
                        char str = '*';
                        Console.Write("{0}{1}{0}{2}{0}{1}{0}", str, new string('/', (n * 2) - 2), new string('|', n));
                    }


                    else
                    {

                        char str = '*';
                        Console.Write("{0}{1}{0}{2}{0}{1}{0}", str, new string('/', (n * 2) - 2), new string(' ', n));
                    }

                }

                Console.WriteLine();
            }



        }
    }
}
