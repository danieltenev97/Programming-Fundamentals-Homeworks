using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerToHexandBinary
{
    class Program
    {
        static void Main(string[] args)
        {


            int a = int.Parse(Console.ReadLine());
           



            Console.WriteLine(Convert.ToString(a, 16).ToUpper());
            Console.WriteLine(Convert.ToString(a,2));
       



        }
    }
}
