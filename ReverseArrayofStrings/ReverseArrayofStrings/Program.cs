using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArrayofStrings
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] a = Console.ReadLine().Split(' ');

            string[] b = a.Reverse().ToArray();

            Console.WriteLine(string.Join(" ",b));

        }
    }
}
