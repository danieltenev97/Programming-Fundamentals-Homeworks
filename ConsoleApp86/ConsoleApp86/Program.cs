using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConsoleApp86
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            BigInteger factoriel = 1;
            int counter = 0;
            for (int i = a; i > 1; i--)
            {
                factoriel = factoriel * i;
            }
            while(factoriel%10==0)
            {
                factoriel = factoriel / 10;
                counter++;
            }
            Console.WriteLine(counter);
           // Console.WriteLine(factoriel);
        }
    }
}
