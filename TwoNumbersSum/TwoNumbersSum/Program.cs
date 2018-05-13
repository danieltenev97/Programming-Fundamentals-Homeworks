using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoNumbersSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());

            int counter = 0;
            int c = 0;
            int d = 0;
            int z = 0;
            int sum = 0;

            for (int i = a; i >=b; i--)
            {
                for (int j = a; j >=b;j--)
                {
                    sum=j + i;
                    counter++;

                    if(sum==number)
                    {
                        c = i;
                        d = j;
                        z = 1;
                        break;
                    }
              }
                if (z == 1) break;

            }

            if(z==1)
            {
                Console.WriteLine($"Combination N:{counter} ({c} + {d} = {number})");
            }
            else
            {
                Console.WriteLine($"{counter} combinations - neither equals {number}");
                
            }
        }
    }
}
