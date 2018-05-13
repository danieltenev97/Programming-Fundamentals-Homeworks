using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasToy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n % 2 != 0) return;

            int m = 5 * n;
            int z = n + 2;
            int x = 1;

            Console.WriteLine("{0}{1}{0}",new string('-',(m-n)/2),new string('*',n));

            for (int i = 1; i <=n/2; i++)
            {

                Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', (m - z-x*2) / 2), new string('*', x),new string('&',z));
                z = z + 2;
                x++;

            }
            int g = n - 1;
            for (int i = 1; i <=n/2; i++)
            {
               
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('-',g), new string('*', 2), new string('~', m-g*2-4));
                g--;
                
               
            }

            Console.WriteLine("{0}*{1}*{0}", new string('-',n/2), new string('|', (m-n-2)));
            g = g + 1;
            for (int i =1; i <=n/2; i++)

            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', g), new string('*', 2), new string('~', m - g * 2 - 4));
                g++;

            }

            x = x - 1;
            z = z - 2;
            for (int i = 1; i <=n/2; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', (m - z - x * 2) / 2), new string('*', x), new string('&', z));
                z = z - 2;
                x--;
            }

            Console.WriteLine("{0}{1}{0}", new string('-', (m - n) / 2), new string('*', n));


        }
    }
}
