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
           int m = 0;
            int a2 = 0;
          
            for (int i = a; i <= b; i++)
            {
                a1 = i / 1000;
                b1 = (i / 100) % 10;
                c = (i / 10) % 10;
                d = (i %10);
              

                if ((a1 % 2 == 0) || (b1 % 2 == 0) || (c % 2 == 0) || (i % 2 == 0)||(c<5)||(b1<3))
                    continue;
                if (a2 == 0)
                {
                    Console.Write("{0} ", i);
                    a2++;
                }
                else
                {
                    if (m == i + 2)
                    {
                        if ((d == c) || (d == c + 2) || (d == c + 4) && ((d == 5) || (d == 7) || (d == 9)))
                        {
                            Console.Write("{0} ", m);
                        }
                    }
                    else
                    {
                        continue;
                    }

                }
                

              
               
            } 

        }
    }
}
