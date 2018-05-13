using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomiseElementsofArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').ToArray();
            var random = new Random();


            for (int i = 0; i < arr.Length; i++)
            {
                var currentindex = arr[i];

                var randomindex = random.Next(0, arr.Length);

                var randomword = arr[randomindex];
                arr[i] = randomword;

                arr[randomindex] = currentindex;

            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
    }
}
