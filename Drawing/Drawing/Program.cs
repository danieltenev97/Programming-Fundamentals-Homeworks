using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing
{
    class Program
    {
        static void draw(int a)
        {
            for (int i =1 ; i <=a; i++)
            {
                if(i==1||i==a)
                {
                    Console.WriteLine(new string('-',a*2));
                }

                else
                {
                    
                    Console.Write("-");
                    for (int j = 1; j <a; j++)
                    {
                        Console.Write("\\/");
                    }
                    Console.Write("-");
                    Console.WriteLine();
                }
            }

        }

        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            draw(a);

        }
    }
}
