using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n < 3) return;

            for (int i = 0; i < n-1; i++)
            {
                int b = n - i;
                int a = (2 * n + 3) - 2 * b - 3;

               
             Console.WriteLine("{0}{1}{2}{1}{2}{1}{0}", new string('.', a / 2), new string('*', 1), new string('.', b));
                
            }

            Console.WriteLine("{0}{1}{0}",new string('.',n-1),new string('*',5));
            Console.WriteLine(new string('*',2*n+3));
            Console.WriteLine("{0}{1}{0}", new string('.', n - 1), new string('*', 5));

            for (int i =n-2; i >=0; i--)
            {
                int b = n - i;
                int a = (2 * n + 3) - 2 * b - 3;


                Console.WriteLine("{0}{1}{2}{1}{2}{1}{0}", new string('.', a / 2), new string('*', 1), new string('.', b));
            }
        }
    }
}
