using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace KeyReplacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string text = Console.ReadLine();
            List<string> takentext = new List<string>();
            

            var splitinput=key.Split('<', '\\','|');

            string beginpattern = splitinput[0];
            string endpattern = splitinput[splitinput.Length -1];

            string pattern = @"[A-Za-z]+";
            Regex regex = new Regex(pattern);

            MatchCollection matchstart = regex.Matches(beginpattern);
            MatchCollection matchend = regex.Matches(endpattern);

            beginpattern = string.Join("", matchstart);
            endpattern = string.Join("", matchend); 


            var newpattern = $@"{beginpattern}(.*?){endpattern}";

            Regex regex1 = new Regex(newpattern);

            MatchCollection match = regex1.Matches(text);

            foreach (Match item in match)
            {
                var value = item.Value.Split(new[] {beginpattern,endpattern }
                ,StringSplitOptions.RemoveEmptyEntries);

                takentext.AddRange(value);


            }


            if(takentext.Count==0)
            {
                Console.WriteLine("Empty result");
               
            }
            
            else 
            Console.WriteLine(string.Join("",takentext));

            
        }
    }
}
