using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp57
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = 0;
            int num = 0;
            for (int i = 1; i <=n; i++)
            {
                if (a == 1) break;
               for(int j=0;j<i;j++)
                    
                {
                   
                    if (i == 1 || i == 2)
                    {
                         num = i + j;

                        Console.Write(num + " ");
                    }
                    else
                    {
                        num = num + 1; ;

                        Console.Write(num + " ");
                      }
                    if (num == n)
                    {
                        a = 1; ;
                        break;
                    }



                }
                Console.WriteLine();
            }

        }
    }
}
