using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a < 1000 || a > 10000) return;

            if (b < 1000 || b>10000) return;
            int a1 = 0;
            int b1 = 0;
            int c = 0;
            int d = 0;

            for (int i = a; i <=b; i++)
            {
                a1 = i / 1000;
                b1 = (i / 100) % 10;
                c = (i / 10) % 10; 
                    d = i % 1000;
                    
            }

        }
    }
}
