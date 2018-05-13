using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace EmailStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> emails = new Dictionary<string, List<string>>();

            int n = int.Parse(Console.ReadLine());
            var patten = @"^([A-Za-z]{5,})@([a-z]{3,}\.(com|bg|org))$";

            Regex regex = new Regex(patten);

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                bool isvalid = regex.IsMatch(input);

               if(isvalid==false)
                {
                    continue;
                }

                Match match = regex.Match(input);
                if (match.Value.Count() == 0)
                {
                    continue;
                }
                string key = match.Groups[2].Value;
                string email = match.Groups[1].Value;

                if (!emails.ContainsKey(key))
                {
                    emails.Add(key, new List<string>());
                }

                if(!emails[key].Contains(email))
                emails[key].Add(email);
            }

            foreach (var item in emails.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{item.Key}:");
                var value = item.Value;

                foreach (var item1 in value)
                {
                    Console.WriteLine($"### {item1}");
                }
            }



        }
    }
}
