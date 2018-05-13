using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int L = int.Parse(Console.ReadLine());

            int specialNumber = int.Parse(Console.ReadLine());
            int controlNumber = int.Parse(Console.ReadLine());

            int number = 100 * M + 10 * N + L;

            int a = 0;
            int i = number;
            while(i>=111)
            {
                 if (i % 3 == 0)
                {
                    specialNumber = specialNumber + 5;
                }
             else if ((i % 10 == 5) && (i % 3 != 0))
                {
                    specialNumber = specialNumber - 2;
                }
                else if ((i % 2 == 0) && (i%3 != 0))
                {
                    specialNumber = specialNumber * 2;
                }

                if (specialNumber >= controlNumber)
                {
                    a = 1;
                    break;
                }

                i--;
            }
               

            if(a==1)
            {
                Console.WriteLine($"Yes! Control number was reached! Current special number is {specialNumber}.");
            }
            else
            {
                Console.WriteLine($"No! {specialNumber} is the last reached special number.");
            }
        }
    }
    }


            