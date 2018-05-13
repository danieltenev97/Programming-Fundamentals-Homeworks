using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraysize = int.Parse(Console.ReadLine());

            int[] array = new int[arraysize];

            for (int i = 0; i <arraysize; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            array = array.Reverse().ToArray();

            for (int i = 0; i <arraysize; i++)
            {
                Console.Write($"{array[i]} ");
            }

        }
    }
}
