using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int c = 4 * n + 1;
            Console.WriteLine(new string('#',c));
            int d = 1;
            if (n % 2 == 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    int m = (c - d - 2 * i) / 2;
                    if (i==n/2+1)
                    {
                        int v = (d - 3) / 2;
                        Console.WriteLine("{0}{1}{2}(@){2}{1}{0}", new string('.', i), new string('#', m), new string(' ', v));
                    }
                    else
                    {

                        Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', i), new string('#', m), new string(' ', d));
                    }
                    d = d + 2;
                }
                int t = n + 1;
                for (int i = 1; i <=n; i++)
                {
                   
                    int z = c - 2 * t;
                    Console.WriteLine("{0}{1}{0}",new string('.',t),new string('#',z));
                    t++;
                }

            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    int m = (c - d - 2 * i) / 2;
                    if (i == n / 2+1)
                    {
                        int v = (d - 3) / 2;
                        Console.WriteLine("{0}{1}{2}(@){2}{1}{0}", new string('.', i), new string('#', m), new string(' ', v));
                    }
                    else
                    {

                        Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', i), new string('#', m), new string(' ', d));
                    }
                    d = d + 2;
                }
                int t = n + 1;
                for (int i = 1; i <= n; i++)
                {

                    int z = c - 2 * t;
                    Console.WriteLine("{0}{1}{0}", new string('.', t), new string('#', z));
                    t++;
                }
            }
        }
    }
}
