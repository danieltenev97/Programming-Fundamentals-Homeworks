using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairbyDiffernce
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int difference = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 0; i <arr.Length; i++)
            {
                for (int j = 0; j <arr.Length ; j++)
                {
                    if(arr[j]==arr[i]+difference||arr[j]==arr[i]-difference)
                    {
                        counter++;
                    }
                }
            }
            int pairs = counter / 2;

            Console.WriteLine(pairs);
        }
    }
}
