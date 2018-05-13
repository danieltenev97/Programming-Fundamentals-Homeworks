using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

           
          
            int i = 0;
            while(arr.Length>1)
            {
                int[] condensed = new int[arr.Length - 1];
                while (i != condensed.Length)
                {
                    condensed[i] = arr[i] + arr[i + 1];
                    i++;
                }

                arr = condensed;
                i = 0;
            }


        

            Console.WriteLine(arr[0]);
        }
    }
}
