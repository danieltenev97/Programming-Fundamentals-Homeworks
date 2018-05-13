using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOD
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int max = 0;
            int maxdel = int.MinValue;
            if (a >= b)
            {
                max = a;
            }
            else
            {
                max = b;
            }

            for (int i = 1; i <= max; i++)
            {
                if ((a % i == 0) && (b % i == 0))
                {
                    maxdel= i;
                }
            }

            Console.WriteLine(maxdel);

        }
    }
}
