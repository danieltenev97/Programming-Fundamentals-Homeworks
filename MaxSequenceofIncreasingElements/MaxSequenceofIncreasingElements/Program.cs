using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceofIncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string arr = Console.ReadLine();

            int[] array = arr.Split(' ').Select(int.Parse).ToArray();

            int startindex = 0;
            int maxindex = 0;
            int length = 1;
            int maxlength = 1;

            for (int i = 1; i <array.Length; i++)
            {
                if(array[i]>array[i-1])
                {
                    length++;
                    
                    if(length>maxlength)
                    {
                        maxlength = length;
                        maxindex =startindex;
                    }
                }
                else
                {
                    startindex = i;
                    length = 1;
                    
                }
            }

            for (int i = maxindex; i <maxindex+maxlength ; i++)
            {
                Console.Write(array[i] + " ");
            }

        }
    }
}
