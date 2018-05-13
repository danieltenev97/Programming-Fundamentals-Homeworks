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

            var messages = new StringBuilder();
            int c = pattern.Length;
           int index = 0;
            int counter = 0;

            if (pattern.Length == 0)
            {
                Console.WriteLine("No shake.");
                Console.WriteLine(randomCharacters);
                return;
            }

            while (true)
                {
                var firstOccureence = randomCharacters.IndexOf(pattern);
                var lastOccureence = randomCharacters.LastIndexOf(pattern);

                /*
                c = pattern.Length;
                    if (index > randomCharacters.Length - c)
                    {
                    if(counter>=2)
                    {
                        Console.WriteLine("Shaked it.");
                    }
                   
                 

                    int remove = c / 2;
                    if(c>1)
                  pattern= pattern.Remove(remove, 1);
                    else
                    {
                        c = 0;
                    }
                        index = 0;
                        counter = 0;
                    }
                   string newrandomCharacters = randomCharacters.Substring(index, c);
                    if (pattern.Equals(newrandomCharacters))
                    {
                        randomCharacters = randomCharacters.Remove(index, c);
                         counter++;
                    }

                    index++; */
                if (firstOccureence > -1 && lastOccureence > -1 && pattern.Length > 0)
                {
                    randomCharacters = randomCharacters.Remove(lastOccureence, pattern.Length);
                    randomCharacters = randomCharacters.Remove(firstOccureence, pattern.Length);
                    messages.AppendLine("Shaked it.");

                    pattern = pattern.Remove(pattern.Length / 2, 1);

                }
                else
                {
                    messages.AppendLine("No shake.");
                    break;
                }
            }

            Console.Write(messages.ToString());
            Console.WriteLine(randomCharacters);


        }
    }
}
