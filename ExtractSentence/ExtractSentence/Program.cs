using System;
using System.Text;
using System.Text.RegularExpressions;

namespace ExtractSentence
{
    class Program
    {
        static void Main(string[] args)
        {

            string word = Console.ReadLine();
            var text = Console.ReadLine();
          
            string pattern = $@"(^| )([\w\-,]|\s)*{word}[ .?!]?([\w\-,]|\s)*";

            Regex regex = new Regex(pattern);
           
            MatchCollection mathes = regex.Matches(text);

            foreach (Match item in mathes)
            {
                var value = item.Value;

                if(value[value.Length-1]=='.'|| value[value.Length - 1]=='!'|| value[value.Length - 1]=='?')
                {
                    Console.WriteLine(item.Value.Remove(item.Value.Length - 1).Trim());
                }

                else
                {
                    Console.WriteLine(item.Value.Trim());
                }
               
            } 

        }
    }
}
