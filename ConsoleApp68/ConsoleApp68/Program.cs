using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp68
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 0;
            int sum = 0;
            int counter = 0;
            int counter1 = 0;

            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <=m; j++)
                {
                    sum = i + j;
                    if(sum==number)
                    {
                        a = i;
                        b = j;
                        counter++;
                    }
                    counter1++;
                }
            }

            if(counter!=0)
            {
                Console.WriteLine($"Number found! {a} + {b} = {number}");
            }

            else
            {
                Console.WriteLine($"{counter1} combinations - neither equals {number}");
            }


        }
    }
}
