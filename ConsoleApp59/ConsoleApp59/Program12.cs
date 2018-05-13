using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp59
{
    class Program
    {
        static void Main(string[] args)
        {

            int monet1 = int.Parse(Console.ReadLine());
            int monet2 = int.Parse(Console.ReadLine());
            int banknota5 = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());
            int sum1 = 0;

            for (int i = 0; i <= monet1; i++)
            {
                for (int j = 0; j <=monet2; j++)
                {
                    for (int k = 0; k <=banknota5; k++)
                    {
                        sum1 = i*1 + j*2 + k*5;

                        if(sum1==sum)
                        {
                            Console.WriteLine($"{i} * 1 lv. + {j} * 2 lv. + {k} * 5 lv. = {sum} lv.");


                        }
                    }
                }

            }
 

        }
    }
}
