using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SrubskoSreGex
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(([A-Za-z]+\s){1,})@(([A-Za-z]+\s){1,})(\d+)\s(\d+)"; //{1,}->edin ili poveche

            Dictionary<string, Dictionary<string, int>> cities
                = new Dictionary<string, Dictionary<string, int>>();


            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End") { break; }

                Regex reg = new Regex(pattern);
                Match match = reg.Match(input);

                if (match.Success)
                {

                    string singer = match.Groups[1].Value.Trim();
                    string city = match.Groups[3].Value.Trim();
                    int ticketprice = int.Parse(match.Groups[5].Value);
                    int ticketpricecount = int.Parse(match.Groups[6].Value);

                    int totalprice = ticketpricecount * ticketprice;


                    if (!cities.ContainsKey(city))
                    {
                        cities.Add(city, new Dictionary<string, int>());
                        cities[city].Add(singer, totalprice);
                    }
                    else
                    {
                        Dictionary<string, int> dictionary = cities[city];

                        if (!dictionary.ContainsKey(singer))
                        {
                            dictionary[singer] = totalprice;

                            cities[city] = dictionary;
                        }
                        else
                        {
                            dictionary[singer] = dictionary[singer] + totalprice;

                            cities[city] = dictionary;
                        }

                    }
                }

            }  
        

            foreach (var item in cities)
            {
                var key = item.Key;
                Console.WriteLine(key);

                var value = item.Value;

                foreach (var item1 in value.OrderByDescending(a => a.Value))
                {

                    Console.WriteLine($"#  {item1.Key} -> {item1.Value}");
                }

            }
        }
    }
}
