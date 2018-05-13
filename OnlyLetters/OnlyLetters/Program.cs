using System;
using System.Text.RegularExpressions;

namespace OnlyLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var pattern = @"([0-9]+)([A-z])";

            Regex regex = new Regex(pattern);

            var mathes = regex.Matches(input);

            foreach (Match item in mathes)
            {
                var digits = item.Groups[1].Value;
                var letter = item.Groups[2].Value;
                input = Regex.Replace(input, digits, letter);
            }

            Console.WriteLine(input);
        }
    }
}
