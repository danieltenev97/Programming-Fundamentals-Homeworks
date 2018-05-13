using System;
using System.Text;
using System.Text.RegularExpressions;

namespace ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();
            string pattern = @"(^| )[a-zA-Z0-9][a-zA-Z0-9.\-_]*@[a-zA-Z0-9-]+(\.[a-z]+)+";

            Regex regex = new Regex(pattern);

            var mathes = regex.Matches(text);
           
            foreach (Match item in mathes)
            {
                Console.WriteLine(item.Value.Trim());
            }

        }
    }
}
