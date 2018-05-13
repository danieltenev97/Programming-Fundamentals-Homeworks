using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloNameMethod
{
    class Program
    {
        static void returname(string a)

        {
            Console.WriteLine($"Hello, {a}!");
        }

        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            returname(name);

        }
    }
}
