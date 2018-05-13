using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            
            int leftsum = 0;
            int rightsum = 0;

            if (arr.Length == 1)
            {
                Console.WriteLine(0);
                return;
            }

            bool a = false;
            for (int i = 0; i < arr.Length-1; i++)
            {
                int[] firstarr = arr.Take(i).ToArray();
                int[] secondarr = arr.Skip(i + 1).ToArray();
                Console.WriteLine(string.Join(" ",secondarr);

                leftsum = firstarr.Sum();
                rightsum = secondarr.Sum();
                if (leftsum==rightsum)
                {
                    Console.WriteLine(i);
                    a = true;
                    break;
                }

              
            }

            if(a==false)
            {
                Console.WriteLine("no");
            } 



        }
    }
}
