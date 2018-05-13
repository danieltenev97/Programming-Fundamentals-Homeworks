using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arr1= Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
         //  int[] newarray = new int[Math.Max(arr.Length, arr1.Length)];
            int b = Math.Min(arr.Length, arr1.Length);
            int a = Math.Max(arr.Length, arr1.Length) - Math.Min(arr.Length, arr1.Length);
            int c = Math.Max(arr.Length, arr1.Length);

            int[] sum = new int[Math.Max(arr.Length, arr1.Length)];
            int index = 0;
           int counter = 0;

            for (int i = 0; i < Math.Max(arr.Length, arr1.Length); i++)
            {
                for (int j = 0; j < Math.Min(arr.Length, arr1.Length); j++)
                {
                
                    if(i==j)
                    {
                        sum[i] = arr[i] + arr1[j];
                    }

                }
            }

            if(b!=c)
            {
                for (int i = 0; i <a ; i++)
                {
                    if (i >= b)
                    {
                        index = 0;
                        
                        if(counter!=0)
                        {
                            index++;
                            if(counter==arr.Length)
                            {
                                index = 0;
                            }
                        }


                            counter++;
                    }
                    if (arr.Length > arr1.Length)
                    {
                       
                        sum[b+i] = arr1[index] + arr[arr1.Length + i];
                        index++;
                        
                    }
                    else
                    {
                        
                        sum[b+i] = arr[index] + arr1[arr.Length + i];
                        index++;
                    }
                }
            }
           
            Console.WriteLine(string.Join(" ",sum));


        }
    }
}
