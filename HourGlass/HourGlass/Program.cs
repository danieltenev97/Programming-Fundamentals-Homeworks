using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HourGlass
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0) return;

            int m = 2 * n + 1;
            int z = 2;
            Console.WriteLine(new string('*',m));
            Console.WriteLine(".*{0}*.", new string(' ', m-4));
            
           for (int i = 1; i <=n-2; i++)
            {

                Console.WriteLine("{0}*{1}*{0}", new string('.', z), new string('@', m -z*2-2));
                z++;
            }
            Console.WriteLine("{0}*{0}", new string('.', (m - 1)/2));

            for (int i = 1; i <=n-2; i++)
            {
                Console.WriteLine("{0}*{1}@{1}*{0}", new string('.', n - i), new string(' ', (m - (n-i)*2-3)/2));
            }

            Console.WriteLine(".*{0}*.", new string('@', m - 4));
            Console.WriteLine(new string('*', m));

        }
    }
}
