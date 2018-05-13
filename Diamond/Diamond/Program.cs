using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

         
            if(n%2==0)
            {
                for (int i = 1; i <=n/2; i++)
                {
                    int a = n / 2 - i;
                    int b = n - 2 * a - 2;
                    Console.WriteLine("{0}{1}{2}{1}{0}",new string('-',a),new string('*',1),new string('-',b));
                    
                } 
               
                for (int i=n/2-1;i>=1; i--)
                {
                    int a = n / 2 - i;
                    int b = n - 2 * a - 2;
                 Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', a), new string('*', 1), new string('-',b));
                 } 
                
            }

            else
            {
                for (int i = 0; i <= n / 2; i++)
                {
                    int a = n / 2 - i;
                    int b = n - 2 * a-2;

                    if(b<0)
                    {
                        Console.WriteLine("{0}{1}{0}", new string('-', a), new string('*', 1));
                    }
                   
                        else
                 Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', a), new string('*', 1), new string('-', b));
                    
                    

                   }
                
                for (int i = n / 2 ; i >= 1; i--)
                {
                    int a = n / 2 +1- i;
                    int b = n - 2 * a-2;

                   if (b>=0)
                        {
                       
                        Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', a), new string('*', 1), new string('-', b));
                    }
                        else
                        {
                        Console.WriteLine("{0}{1}{0}", new string('-', a), new string('*', 1));
                           
                    }
                   
                }
                
            }

        }
    }
}
