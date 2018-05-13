using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsFirstExercise
{
    class Program
    {
        static void Main(string[] args)
        {
          //  string a = Console.ReadLine();
            // char[] b = a.Reverse().ToArray();

            // Console.WriteLine(string.Join("",b));

            string[] a1= new string[3];

            a1 = Console.ReadLine().Split(' ');

            string[] c = a1.Reverse().ToArray();
            Console.WriteLine(string.Join(" ",c));
        }
    }
}
