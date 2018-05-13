using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softunilogo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = 12 * n - 5;
            int z = 1;
            int k = 4 * n - 2;
            int v = k - n * 3;

            for (int i = 1; i <= n * 2; i++)
            {

                Console.WriteLine("{0}{1}{0}", new string('.', (m - z) / 2), new string('#', z));
                z = z + 6;
            }

            z = 2;
           
            for (int i = 1; i <= n+v; i++)
            {
                if(i<=v)
                {
                    Console.WriteLine("|{0}{1}{2}", new string('.', z), new string('#', m - 2 * z - 1), new string('.', z + 1));
                    z = z + 3;
                }
                 else if (i == n+v)
                {
                    Console.WriteLine("@{0}{1}{2}", new string('.', z), new string('#', m - 2 * z - 1), new string('.', z + 1));
                }
                else
                {
                    Console.WriteLine("|{0}{1}{2}", new string('.', z), new string('#', m - 2 * z - 1), new string('.', z + 1));
                }
            }
        }
    }
}
