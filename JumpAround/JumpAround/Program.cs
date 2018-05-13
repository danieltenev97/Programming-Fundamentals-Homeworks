using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace JumpAround
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int sum = 0;
            int number = 0;
            for (int i = 0;;)
               
            {
                number = arr[i];
                if(i+number<arr.Length)
                {
                    i = i + number;
                    sum = sum + number;
                }

                else if(i-number>=0)
                {
                    i = i - number;
                    sum = sum + number;
                }
                else
                {
                    sum = sum + number;
                    break;
                }


            }

            Console.WriteLine(sum);
        }
    }
}
