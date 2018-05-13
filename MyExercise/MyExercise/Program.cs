using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int lastdigit = arr[arr.Length - 1];
            //int startdigit = arr[0];
           
       
            for (int i = arr.Length - 1; i > 0; i--)
            {
                arr[i] = arr[i - 1];
            } 


             arr[0] = lastdigit;
          //  arr[arr.Length - 1] = startdigit;
            Console.WriteLine(string.Join(" ",arr));

            
        }
    }
}
