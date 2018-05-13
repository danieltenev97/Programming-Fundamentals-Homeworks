using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoleworDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());

          if((int)a>=48&&(int)a<58)
            {
                Console.WriteLine("digit");
            }
            else if((int)a==97|| (int)a==101|| (int)a==105|| (int)a==111|| (int)a==117|| (int)a==65|| (int)a==69|| (int)a==79|| (int)a==73|| (int)a==85)
            {
                Console.WriteLine("vowel");
            }
          else
            {
                Console.WriteLine("other");
            }

        }
    }
}
