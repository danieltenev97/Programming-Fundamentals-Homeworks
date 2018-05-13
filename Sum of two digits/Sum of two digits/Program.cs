using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_two_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());
            int c = 0;
            int counter = 0;
            int n = 0;
            int v = 0;
            int z = 0;

            for (int i = a; i <=b; i++)
            {
                for (int j = a; j <=b; j++)
                {
                    c = i + j;
                    counter++;
                    if (c==number)
                    {
                        n = 1;
                        z = i;
                        v = j;
                        break;
                    }

                    
                }
                if (n == 1) break;

            }

            if(n==1)
            {
                Console.WriteLine($"Combination N:{counter} ({z} + {v} = {number})");
            }
            else
            {
                Console.WriteLine($"{counter} combinations - neither equals {number}");
            }

        }
    }
}
