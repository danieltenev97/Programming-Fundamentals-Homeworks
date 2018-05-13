using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeBoundries
{
    class Program
    {
        static void Main(string[] args)
        {

            string type = Console.ReadLine();

            if(type.Equals("int"))
            {
                Console.WriteLine(int.MaxValue);
                Console.WriteLine(int.MinValue);
            }
            else if(type.Equals("uint"))
            {
                Console.WriteLine(uint.MaxValue);
                Console.WriteLine(uint.MinValue);
            }
            else if(type.Equals("long"))
            {
                Console.WriteLine(long.MaxValue);
                Console.WriteLine(long.MinValue);
            }

            else if(type.Equals("byte"))
            {
                Console.WriteLine(byte.MaxValue);
                Console.WriteLine(byte.MinValue);
            }
            else if(type.Equals("sbyte"))
            {
                Console.WriteLine(sbyte.MaxValue);
                Console.WriteLine(sbyte.MinValue);
            }

        }
    }
}
