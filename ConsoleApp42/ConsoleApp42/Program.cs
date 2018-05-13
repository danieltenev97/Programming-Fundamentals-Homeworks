using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int a = (n * 3 - 1) / 2;
            int b= (n * 3 - 3) / 2;
            if (n % 2 == 0) return;
            
            Console.WriteLine("{0}{1}{0}",new string('.',a),new string('x',1));
            Console.WriteLine("{0}{1}{2}\\{0}" , new string('.', b), new string('/', 1), new string('x', 1));
            Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', b), new string('x', 1), new string('|', 1));
            int c = n;
            for (int i=1;i<=n;i++)
            {
                if (i <= n / 2 + 1&&i!=1)
                {
                    c++; 
                }

                else if(i>n/2)
                {
                    c--;
                }
                int d = (n* 3)-c * 2 - 1; 
              
            Console.WriteLine("{0}{1}{2}{1}{0}",new string('.',d/2), new string('x', c), new string('|', 1));
                
            }

            Console.WriteLine("{0}{1}{2}\\{0}", new string('.', b), new string('/', 1), new string('x', 1));
            Console.WriteLine("{0}\\{1}/{0}", new string('.', b),  new string('x', 1));
        }
    }
}
