using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n % 2 != 0) return;

            int c = 2 * n - 1;
            Console.WriteLine("{0}{1}{0}{1}{0}",new string('@',1),new string(' ',(c-3)/2));
            Console.WriteLine("{0}{1}{2}{1}{0}", new string('*', 2), new string(' ', (c - 5) / 2),new string('*',1));
            int d = 1;

            for (int i = 1; i <=n/2; i++)
            {
                int m = (c - 2 * i - d - 6)/2;
                if (m <= 0&&i!=n/2)
                {
                    Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", new string('*', 1), new string('.', i), new string('.', d));
                }
                else if(i==n/2)
                {
                    int v = (c - 2 * i - 2 - 1) / 2;
                      Console.WriteLine("{0}{1}{2}{3}{2}{1}{0}",new string('*',1), new string('.', i), new string('*', v), new string('.', 1));
                }

                else
                {
                    Console.WriteLine("{0}{1}{0}{2}{0}{3}{0}{2}{0}{1}{0}", new string('*', 1), new string('.', i), new string(' ', m), new string('.', d));
                }
                d = d + 2;
            }


            for (int i = 0; i <2; i++)
            {
                Console.WriteLine(new string('*',c));
            }
        }
    }
}
