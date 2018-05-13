using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

                for (int j=1;j<=n;j++)
                {
                    if(j==1)
                    {
                        Console.Write(new string(' ',n-1));
                        Console.Write("*");
                        Console.Write(new string(' ', n - 1));
                    }
                    else 
                    {
                        Console.Write(new string(' ', n - j));
                        for(int k=1;k<=j;k++)
                        {
                            Console.Write("* ");
                        }
                    }
                Console.WriteLine();
             }

             for(int i=n-1;i>=1;i--)
            {
                if (i == 1)
                {
                    Console.Write(new string(' ', n - 1));
                    Console.Write("*");
                    Console.Write(new string(' ', n - 1));
                }
                else
                {
                    Console.Write(new string(' ', n - i));
                    for (int k = 1; k <= i; k++)
                    {
                        Console.Write("* ");
                    }
                }
                Console.WriteLine();

            } 

        }
    } 
        }
    

