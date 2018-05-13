using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp55
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter even number: ");
            int n=0;

            try
            {
                while (true)
                {
                    n = int.Parse(Console.ReadLine());
                    if (n % 2 == 0)
                    {
                        Console.WriteLine("Even number entered {0}", n);
                        break;
                    }

                    else
                    {
                        Console.WriteLine("The number is not even");
                    }
                }
            }
            catch
            {
                Console.WriteLine("Invalid number!");
            }
          



        }
    }
}
