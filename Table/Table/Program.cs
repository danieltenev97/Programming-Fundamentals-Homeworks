using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
          
            for (int i = 0; i <n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    int num = j + i;
                    if (j == 1)
                    {
                         num = j + i;
                        Console.Write(num + " ");
                    }
                    else if(j==n)
                    {
                        num = n - i; ;
                        Console.Write(num + " ");
                        
                    }
                    else
                    {
                        if (num <= n)
                        {
                            num = j + i;
                        }
                        else
                        {
                            num =n-(num-n);
                           
                        }
                      Console.Write(num + " ");
                        
                    }

                }
                Console.WriteLine();
            }

        }
    }
}
