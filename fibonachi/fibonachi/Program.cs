using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonachi
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           int sum = 0;
            int a = 1;
            int b = 1;
         
           
  
            
                for (int i = 0; i <n-1; i++)
                {
                    sum = a + b;
                    a = b;
                    b = sum;
                  
                    
                }
                Console.WriteLine(sum);
            

        }
    }
}
