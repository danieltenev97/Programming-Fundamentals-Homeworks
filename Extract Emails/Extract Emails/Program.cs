using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(^| )[a-zA-Z\0-9][a-zA-Z0-9.\-_]*@[a-zA-Z-]+(\.[a-z]+)+";

            Regex regex = new Regex(pattern);
            string text = Console.ReadLine();

            MatchCollection match = Regex.Matches(text,pattern);


            foreach (Match item in match)
            {
                Console.WriteLine(item.Value.Trim(' '));
            }
        }
    }
}
