using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp44
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int c = 5 * n;
            if (n % 2 != 0 || n < 6) return;

            for (int i = 0; i <n/2; i++)
            {
                int b = n + i;
                int d = c - 2 * b;
                Console.WriteLine("{0}{1}{0}",new string('.',b),new string('#',d));
            }
            int b1 = n + n / 2;
            for (int i = 0; i<n/2+1; i++)
            {
                int b = n + n / 2;
                int d = c - 2 * b1 - 2;
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', b1), new string('#', 1), new string('.', d));
                b1++;
            }

            Console.WriteLine("{0}{1}{0}", new string('.',(c-n)/2), new string('#',n));

            for (int i = 0; i < n / 2; i++)
            {
                int v = (c - (n + 4)) / 2;
                
                    Console.WriteLine("{0}{1}{0}", new string('.', v), new string('#', n + 4));
                
            }

            Console.WriteLine("{0}D^A^N^C^E^{0}", new string('.', (c-10)/2));
            for (int i = 0; i <=n/2; i++)
            {
                int v = (c - (n + 4)) / 2;
                Console.WriteLine("{0}{1}{0}", new string('.', v), new string('#', n + 4));

            }



        }
    }
}
