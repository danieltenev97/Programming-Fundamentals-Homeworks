using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp67
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());

            int sum = 0;
            int total = 0;
            int left = 0;
            int counter = 0;

            for (int i = n; i >= 1; i--)
            {
                if(total>=max)
                {
                    break;
                }
                for (int j = 1; j <=m; j++)
                {
                    sum = (i * j) * 3;
                    total = total + sum;
                    counter++;

                    if (total >= max)
                    {
                        left = total - max;
                        break;
                    }
                }
            }

            if(total>=max)
            {
                Console.WriteLine($"{counter} combinations");
                Console.WriteLine($"Sum: {total} >= {max}");
            }
            else
            {
                Console.WriteLine($"{counter} combinations");
                Console.WriteLine($"Sum: {total}");
            }
        }
    }
}
