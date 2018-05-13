using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kvadratna_ramka
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

           
                for (int j = 1; j <= n; j++)
                {
                    
                    if (j == 1 || j == n)
                    {
                        Console.Write("+ ");
                        for(int k=1;k<=n-2;k++)
                        {
                            Console.Write("- ");
                        }
                        Console.Write("+ ");
                      
                    }
                    else
                    {
                        Console.Write("| ");
                        for (int m = 1; m <= n - 2; m++)
                        {
                            Console.Write("- ");
                        }
                        Console.Write("| ");
                    }
                    Console.WriteLine();
                }
                

            
        }
    }
}
