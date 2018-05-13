using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            long a = 0;

            try
            {
                a = long.Parse(Console.ReadLine());
                Console.WriteLine("integer");
            }

            catch
            {
                Convert.ToDouble(a);
              
                Console.WriteLine("floating-point");
            }
           

        }
    }
}
