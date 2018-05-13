using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractMiddle
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] revesredarr = arr.Reverse().ToArray();
            
         if(arr.Length==1)
            {
                Console.WriteLine("{ " + arr[0] + " }");
                return;
            }

            if(arr.Length%2!=0)
            {
                int b= arr.Length / 2;
                Console.WriteLine("{ " + arr[b - 1] + ", " + arr[b] + ", " + arr[b + 1] + " }");
            }
           else
            {
                int b = arr.Length / 2-1;
                Console.WriteLine("{ " + arr[b] + ", " + arr[b+1] + " }");
            }
            
        }
    }
}
