using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int counter = 1;
            

            for (int i = 2; i <=a; i++)
            {
                for (int j = 1; j <i; j++)
                {
                    if (j == i)
                    {
                        counter++;
                    }

                    else
                    {
                        if (i % j == 0)
                        {
                            counter++;
                        }
                    }

                }

                if(counter<=2)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else if(counter>2)
                {
                    Console.WriteLine($"{i} -> False");
                }
                counter = 1;
            }

        }
    }
}
