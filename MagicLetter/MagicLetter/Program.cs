using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());

            for (char i = a; i <=b; i++)
            {
                for (char k = a; k <=b; k++)
                {


                    for (char j = a; j <= b; j++)
                    {
                        if (i.Equals(c) || j.Equals(c)||k.Equals(c))
                        {
                            continue;
                        }

                        Console.Write($"{i}{k}{j} ");
                    }
                }
            }


        }
    }
}
