using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int counter = 1;
            int maxcounter = 1;
            int mostfrequent = 1;
       
            for (int i = 0; i <arr.Length; i++)
            {
                counter = 1;
                for (int j = 0; j <arr.Length; j++)
                {
                    if(arr[i]==arr[j])
                    {
                        counter++;
                    }
                }
                if (counter > maxcounter)
                {
                    maxcounter = counter;
                    mostfrequent = arr[i];
                }
               
               
            }
            
            Console.WriteLine(mostfrequent);
        }
    }
}
