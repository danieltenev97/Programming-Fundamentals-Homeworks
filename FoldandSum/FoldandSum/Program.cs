using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldandSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            if(arr.Length<4||arr.Length%2!=0)
            {
                return;
            }
            int k = arr.Length / 4;

            int[] left = arr.Take(k).ToArray();
            int[] mid = arr.Skip(k).Take(2*k).ToArray();
            int[] right = arr.Skip(3*k).Take(k).ToArray();

            Array.Reverse(left);
            Array.Reverse(right);

            int[] result = new int[2 * k];

            for (int i = 0; i <k; i++)
            {
                result[i] = left[i] + mid[i];
                result[i + k] = right[i] + mid[i + k];
            }

            Console.WriteLine(string.Join(" ",result));
        }
    }
}
