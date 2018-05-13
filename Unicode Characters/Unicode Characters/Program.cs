using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {

            var a = new UnicodeEncoding();

            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                Console.Write("\\u{0:x4}", (int)text[i]);
            }
            Console.WriteLine();

        }

    }
}
