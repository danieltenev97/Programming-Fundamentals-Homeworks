using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().ToLower().Split(' ');

            Dictionary<string, int> wordcontains = new Dictionary<string, int>();
            List<string> wordcound = new List<string>();

            foreach (var Word in words)
            {
                if(wordcontains.ContainsKey(Word))
                {
                    wordcontains[Word]++;
                }
                else
                {
                    wordcontains[Word]=1;
                }
            }

            foreach (var item in wordcontains)
            {
                if(item.Value%2!=0)
                {
                    wordcound.Add(item.Key);
                }
            }

            Console.WriteLine(string.Join(", ",wordcound));

        }
    }
}
