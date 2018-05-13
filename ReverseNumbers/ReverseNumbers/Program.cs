using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumbers
{
    class Program
    {
        static void Reverse(decimal a)
        {

            


            if (a % 1 == 0)
            {
                int b = 0;
                while (true)
                {
                    if (a == 0) break;
                    b = (int)(a % 10);
                    Console.Write(b);
                    a = (int)(a / 10);
                }
                Console.WriteLine();
            }

            else
            {
                int counter = 0;
                while (true)
                {
                    if (a % 1 == 0)
                    {
                        break;
                    }
                    a = a * 10;
                    
                    counter++;
                }
                    int b = 0;
                int counter1 = 0;
                while (true)
                    {
                        
                        if (a == 0) break;
                        b = (int)(a % 10);
                    if (counter == counter1)
                    {
                        Console.Write($".{b}");
                    }
                    else
                    {
                        Console.Write(b);
                    }
                        a = (int)(a / 10);
                    counter1++;
                    }
                Console.WriteLine();
            }
            
        }

        static void Main(string[] args)
        {
            decimal a = decimal.Parse(Console.ReadLine());
            Reverse(a);
           
        }
    }
}
