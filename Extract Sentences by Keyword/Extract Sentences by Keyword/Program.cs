using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Extract_Sentences_by_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            var text = Console.ReadLine().Split(new[] { ".","?","!" },StringSplitOptions.RemoveEmptyEntries);
          

          //  string pattern = $@"( |\w)+ {word}[ A-Za-z0-9]+";

         

            foreach (var sentce in text)
            {
                var words = Regex.Split(sentce, @"[^a-zA-Z0-9]+");
                foreach (var word1 in words)
                {
                    if(word1==word)
                    {
                        Console.WriteLine(sentce);
                        break;
                    }
                }
            }


        }
    }
}
