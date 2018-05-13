using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPow
{
    class Program
    {
        static decimal mathpow(decimal a,decimal b)
        {
            decimal result = 1;
            for (int i = 1; i <=b; i++)
            {
                result = result * a;
            }

            return result;
        }

        static void Main(string[] args)
        {
            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());

            decimal result = mathpow(a, b);
            Console.WriteLine(result);

        }
    }
}
