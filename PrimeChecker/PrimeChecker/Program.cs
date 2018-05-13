using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeChecker
{
    class Program
    {
        private static bool PrimerChecker(long a)
        {
            int counter = 0;
            for (long i = 1; i <=a/2; i++)
            {
                try
                {
                   a= (int)a;
                }
                catch
                {
                    a = a / 100;
                }
                if(a%i==0)
                {
                    counter++;
                }

                if (counter > 1) break;

            }

            if(counter==1)
            {
                return true;
            }

            else 
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());

            bool result = PrimerChecker(number);
            Console.WriteLine(result);
            }
        }
    }

