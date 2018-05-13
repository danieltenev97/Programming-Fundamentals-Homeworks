using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AnonymousVox
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string replace = Console.ReadLine();

            MatchCollection matches = Regex.Matches(replace, @"({)(.*?)(})");
            MatchCollection placeholdersmatch = Regex.Matches(text, @"([A-Za-z]+)(.+)(\1)");

            List<string> replacematch = new List<string>();

            
            foreach (Match item in matches)
            {
                var add = item.Groups[2].Value;
                replacematch.Add(add);
            }

            for (int i = 0; i <Math.Min(placeholdersmatch.Count,replacematch.Count) ;i++)
            {
                string replacewith = replacematch[i];
                string replaced = placeholdersmatch[i].Groups[2].Value;

               // text = Regex.Replace(text, replaced, replacewith);
                int index = text.IndexOf(replaced);
                text = text.Remove(index, replaced.Length);
               text = text.Insert(index, replacewith);

            }

            Console.WriteLine(text);
        }
    }
}
