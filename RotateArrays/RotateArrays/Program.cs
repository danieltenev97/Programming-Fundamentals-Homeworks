using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();

            int[] arr = numbers.Split(' ').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int m = 0;
            int n1 = 0;
            int[] sum = new int[arr.Length];


            for (int i = 0; i < n; i++)
            {
              
              for (int j = 0; j < arr.Length; j++)
                    {

                    for (int k = 0; k <arr.Length; k++)
                    {

                        if (j != 0)
                        {
                            n1 = arr[j];
                            arr[j] = arr[j - 1];
                            //  sum[j] = n + sum[j];
                        }


                        else
                        {
                            m = arr[0];
                            arr[0] = arr[arr.Length - 1];
                            //  sum[j] = m + sum[0];
                        }

                    } 
                 

                    }


                
            }
            Console.WriteLine(string.Join(" ",arr));
           

        }
    }
}
