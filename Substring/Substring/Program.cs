using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substring
{
    class Program
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            int jump = int.Parse(Console.ReadLine());
            int counter = 0;
             char Search = 'р';
            bool hasMatch = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == Search)
                {
                    hasMatch = true;
                    counter++;
                   Console.Write(text[i]);
                   
                }

                if(counter!=0&&counter<=jump+1)
                {
                    Console.Write(text[i]);
                    counter++;
                }

            }

            if(hasMatch==false)
            {
                Console.WriteLine("no");
            }
        }
    }
}
