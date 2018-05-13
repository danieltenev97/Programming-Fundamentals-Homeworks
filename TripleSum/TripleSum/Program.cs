using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool counter = false;
            int a = 0;
            int b = 0;
            int c = 0;
            for (int i = 0; i <arr.Length ; i++)
            {
                a = arr[i];
                for (int j = 0; j <arr.Length ; j++)
                {
                    if (j == i) continue;
                    b = arr[j];
                    for (int k = 0; k <arr.Length; k++)
                    {
                        c = arr[k];
                        if(a+b==c&&j>i)
                        {
                            counter=true;
                            Console.WriteLine($"{a} + {b} == {c}");
                        }
                    }

                }
            }

            if(counter==false)
            {
                Console.WriteLine("No");
            }
                 


        }
    }
}
