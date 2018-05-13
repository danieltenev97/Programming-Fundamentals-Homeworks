using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumArrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int a = Math.Max(arr.Length, arr1.Length);
            int b= Math.Min(arr.Length, arr1.Length);

            int[] newarray = new int[a];
            int[] sum= new int[a];
           
            if (arr.Length>arr1.Length)
            {
                for (int i = 0; i < a; i++)
                {
                 
                 
                  newarray[i] = arr1[i%b];
                  sum[i] = newarray[i] + arr[i];
                }
            }
            else if (arr1.Length > arr.Length)
            {
                for (int i = 0; i < a; i++)
                {
                    
                        newarray[i] = arr[i%b];
                        sum[i] = newarray[i] + arr1[i];
                    
                }
            }
            
            else
            {
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j <b; j++)
                    {

                        if (i == j)
                        {
                            sum[i] = arr[i] + arr1[j];
                        }

                    }
                }
            }
            
            Console.WriteLine(string.Join(" ", sum));
            
            

        }
    }
}
