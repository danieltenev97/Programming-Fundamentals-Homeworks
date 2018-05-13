using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonachiNumbers

{ 

    class Program
    {
        static void Fibonachi(int a)
        {
            decimal c = 0;
            decimal n = 1;

            for (int i=0;i<=a;i++)
            {
                decimal temp = c;
                c = n;
                n = temp + c;
               
                
            }
            Console.WriteLine(c);

        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Fibonachi(n);
            
        }
    }
}
