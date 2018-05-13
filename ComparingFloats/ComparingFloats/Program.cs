using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

           if(Math.Max(a,b)-Math.Min(a,b)< 0.000001)
            {
                Console.WriteLine("True");
            }
           else
            {
                Console.WriteLine("False");
            }

        }
    }
}
