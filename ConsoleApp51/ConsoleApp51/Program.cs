using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            
            while(b!=0)
            {
                var b1 = b;
                b = a % b;
                a = b1;
            }

            Console.WriteLine(a);
        }
    }
}
