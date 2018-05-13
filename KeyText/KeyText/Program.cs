using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Text;

namespace KeyText
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string text = Console.ReadLine();

            var pattern =  @"([A-Za-z]+)([<\\\|])(.*)([<\\\|])([A-Za-z]+)";

            Regex regex = new Regex(pattern);

            Match match = regex.Match(key);

            string start = match.Groups[1].Value;
            string end = match.Groups[5].Value;

            string patten1=$@"({start})(.*?)({end})";

            MatchCollection matches = Regex.Matches(text, patten1);

          

             StringBuilder mystring = new StringBuilder();

            foreach (Match item in matches)
            {
                string a = item.Groups[2].Value;
                mystring.Append(a);

            }

            if (mystring.Length== 0)
            {
                Console.WriteLine("Empty result");
                return;
            }

            Console.WriteLine(mystring);
        }
    }
}
