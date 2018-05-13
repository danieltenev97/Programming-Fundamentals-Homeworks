using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequnceofEqual
{
    class Program
    {
        static void Main(string[] args)
        {
            string arr = Console.ReadLine();
            

            int[] array = arr.Split(' ').Select(int.Parse).ToArray();
            int index = 0;
            int maxindex = 0;
            int counter=1;
            int BestCounter = 1;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                {
                    counter++;
                    

                    if (counter > BestCounter)
                    {
                        BestCounter = counter;
                        maxindex = index;
                    }
                }
                else
                {
                    index = i;
                    counter = 1;
                }

            }
            for (int i = maxindex; i <maxindex+BestCounter; i++)
            {
                Console.Write(array[i]+" ");
            }
          
        }
    }
}
