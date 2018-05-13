using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPrimeNumbersinArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n+1];
            int counter = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = i;
                for (int j = 1; j <=i ; j++)
                {
                    if(i%j==0)
                    {
                        counter++;
                    }
                }

                if(counter==2)
                {
                    Console.Write(arr[i]+" ");
                }
                counter = 0;
            }
        }
    }
}
