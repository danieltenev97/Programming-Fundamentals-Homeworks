using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace SumBigInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());

            BigInteger number1 = BigInteger.Parse(Console.ReadLine());

            BigInteger result = number1 + number;

            Console.WriteLine(result);



        }
    }
}
