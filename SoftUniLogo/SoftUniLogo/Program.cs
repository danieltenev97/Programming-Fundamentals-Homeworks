﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniLogo
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int m = 12 * n - 5;
            int z = 1;
            int x = 0;
            
            for (int i =1; i<=n*2; i++)
            {
                Console.WriteLine("{0}{1}{0}",new string('.',(m-z)/2),new string('#',z));
                z = z + 6;
            }
            
            z = 2;
            x = 3;
            for (int i = 1; i <=n*2-2; i++)
            {
                if (x < n *2)
                {
                    Console.WriteLine("|{0}{1}{2}", new string('.', z), new string('#', m - z - x - 1), new string('.', x));
                    z = z + 3;
                    x = z + 1;
                }
                else if (i == n*2-2)
                {
                    Console.WriteLine("@{0}{1}{2}", new string('.', z), new string('#', m - z - x - 1), new string('.', x));
                }
                else
                {
                    Console.WriteLine("|{0}{1}{2}", new string('.', z), new string('#', m - z - x - 1), new string('.', x));
                }

                
            }

    

        }
    }
}
