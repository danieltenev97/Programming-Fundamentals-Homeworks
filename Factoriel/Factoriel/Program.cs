using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factoriel
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int factoriel = 1;
            for (int i = n; i >=1; i--)
            {
                factoriel = factoriel * i;
            }
            Console.WriteLine(factoriel);
        }
    }
}
