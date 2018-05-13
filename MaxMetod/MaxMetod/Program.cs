using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMetod
{
    class Program
    {
        static int GetMax(int a,int b)
        {
            return Math.Max(a, b);
        }

        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if(b<=c)
            {
                b = c;
            }

            int result = GetMax(a, b);
            Console.WriteLine(result);

        }
    }
}
