using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crown
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n % 2 != 0) return;
            int m = 2 * n - 1;
            Console.WriteLine("{0}{1}{0}{1}{0}", new string('@', 1), new string(' ', (2 * n - 4) / 2));
            Console.WriteLine("{0}{1}*{1}{0}", new string('*', 2), new string(' ', (2 * n - 6) / 2));

            int c = 1;
            for (int i = 1; i <= n / 2 ; i++)
            {
              
            int b = m - 2 * i -  c - 6;
                if (i == n / 2)
                {
                    int z = m - n - 3;

                    Console.WriteLine("{0}{1}{2}{3}{2}{1}{0}", new string('*', 1), new string('.', i), new string('*', z/2), new string('.', 1));
                }

                else if (i == n / 2 - 1)
                {
                    int z = m - 2 * i - 4;
                    Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", new string('*', 1), new string('.', i), new string('.', z));
                }

                else
                {
                    Console.WriteLine("{0}{1}{0}{2}{0}{3}{0}{2}{0}{1}{0}", new string('*', 1), new string('.', i), new string(' ', b / 2), new string('.', c));
                }
            c = c + 2;

            }


            Console.WriteLine(new string('*', 2 * n - 1));
            Console.WriteLine(new string('*', 2 * n - 1));

        
    }
}

}

