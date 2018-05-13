using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodsTask2
{
    class Program
    {
        static void checksign(int a)
        {
            if(a>0)
            {
                Console.WriteLine($"The number {a} is positive.");
            }
            else if(a<0)
            {
                Console.WriteLine($"The number {a} is negative.");
            }
            else
            {
                Console.WriteLine("The number 0 is zero.");
            }
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            checksign(a);
        }
    }
}
