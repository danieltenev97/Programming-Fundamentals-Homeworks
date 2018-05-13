using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> countries
                = new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, long> populations = new Dictionary<string, long>();

            while(true)
            {
                var input = Console.ReadLine();

                if(input=="report") { break; }

                var command = input.Split(new[] { "|" }, StringSplitOptions.RemoveEmptyEntries);

                string city = command[0];
                string country = command[1];
                long population = long.Parse(command[2]);
               
                if(!countries.ContainsKey(country))
                {
                    countries.Add(country, new Dictionary<string, long>());
                    countries[country].Add(city, population);
                    populations[country] = population;
                }

                else
                {
                    Dictionary<string, long> dictionary = countries[country];
                    dictionary[city] = population;
                    populations[country] += population;

                    countries[country] = dictionary;
                }
                        
            }

          
            foreach (var item in populations.OrderByDescending(a=>a.Value))
            {
                Console.WriteLine($"{item.Key} (total population: {item.Value})");
                foreach (var item1 in countries)
                {
                    string key = item1.Key;

                    if(key==item.Key)
                    {
                        var value = item1.Value;
                        foreach (var cities in value.OrderByDescending(a=>a.Value))
                        {
                            Console.WriteLine($"=>{cities.Key}: {cities.Value}");
                        }
                    }
                }
            }

          
           
        }
    }
}
