using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manipulate_Array
{
    class Program
    {
        static void Main(string[] args)
        {

            var text = Console.ReadLine().Split(' ').ToArray();
            // int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            while (!input.Equals("END"))
            {
                var newinput = input.Split(' ');

                if(newinput[0].Equals("Reverse"))
                {
                    //  text = text.Reverse().ToArray(); // bavno e
                    Array.Reverse(text); // po burzo e 
                }

                else if(newinput[0].Equals("Distinct"))
                {
                    text = text.Distinct().ToArray();
                  
                }

                else if(newinput[0].Equals("Replace"))
                {
                    int index =int.Parse(newinput[1]);
                    try
                    {
                        text[index] = newinput[2];

                    }
                    catch
                    {
                        Console.WriteLine("Invalid input!");
                    }
            
                }

                else
                {
                    Console.WriteLine("Invalid input!");
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ",text));
        }
    }
}
