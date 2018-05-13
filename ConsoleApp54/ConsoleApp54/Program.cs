using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp54
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int m = 1;
            int a = n / 10;
            if(n<1000)
            {
                a = n;
            }

            for (int i = 1; i <=a; i++)
            {

                if(n%i==0)
                {
                    m++;
                }

            }

            if (m == 2&&n>=2)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
             

        }
    }
}
