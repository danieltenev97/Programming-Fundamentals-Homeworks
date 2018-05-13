using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int number = 1;
            
            for (int i = 0; i <=n; i++)
            {
               
                if(i%2==0)
                {
                    Console.WriteLine(number);
                    number = number * 2;
                }
                else
                {
                    number = number * 2;
                }


            }
        }
    }
}
