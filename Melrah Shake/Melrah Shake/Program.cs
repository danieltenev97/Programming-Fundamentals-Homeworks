using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melrah_Shake
{
    class Program
    {
        static void Main(string[] args)
        {

            string randomCharacters = Console.ReadLine();
            string pattern = Console.ReadLine();

            pattern = pattern.Remove(2, 2);
            int c = pattern.Length;
           int index = 0;
            int counter = 0;
           // bool end = true;
           
             /*   while (c>0)
                {
                    if (index > randomCharacters.Length - c)
                    {
                    if(counter>=2)
                    {
                        Console.WriteLine("Shake it");
                    }
                    else
                    {
                        Console.WriteLine("No shake");
                    }
                    int remove = c / 2;
                    pattern.Remove(remove, remove);
                        index = 0;
                        counter = 0;
                    }
                    randomCharacters = randomCharacters.Substring(index, c);
                    if (pattern.Equals(randomCharacters))
                    {
                        randomCharacters = randomCharacters.Remove(index, c);
                         counter++;
                    }

                    index++;
                }  */
            

        }
    }
}
