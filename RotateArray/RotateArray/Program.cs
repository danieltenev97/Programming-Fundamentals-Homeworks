using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateArray
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());
            int[] rotatedarr = new int[arr.Length];
          //  int lastdigit = 0;
            

            for (int j = 0; j < k; j++)
            {

             int   lastdigit = arr[arr.Length - 1];
               
                for (int i = arr.Length-1; i>0; i--)
                {
                    arr[i] = arr[i - 1];
                    rotatedarr[i] = rotatedarr[i] + arr[i];
                
                    
                }
                arr[0] = lastdigit;
                rotatedarr[0] = rotatedarr[0] + arr[0];

              }
            
            Console.Write(string.Join(" ",rotatedarr));

        }
    }
}
