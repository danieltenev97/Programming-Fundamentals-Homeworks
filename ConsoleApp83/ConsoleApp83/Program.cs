using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp83
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] array = new char[3];

            for (int i = 0; i < 3; i++)
            {
                array[i] = char.Parse(Console.ReadLine());
            }
          
            
     for (int i = 2; i >=0; i--)
          {
                Console.Write(array[i]);
            }

     

        }
    }
}
