using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Сръбско_Unleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> cities 
                = new Dictionary<string, Dictionary<string, long>>();


            while(true)
            {
                string input = Console.ReadLine();

                if(input=="End") { break; }

                var commands = input.Split(new[] { "@" }, StringSplitOptions.RemoveEmptyEntries);
            //    Console.WriteLine(string.Join(" ",commands));
            //    Console.WriteLine(commands.Length);
                if (commands.Length != 2) { continue; }
                string singer = commands[0];

                var second = commands.Skip(1).ToArray();
                string secondsplit = string.Join(" ", second);
            //    Console.WriteLine(secondsplit);

                var commands1 = secondsplit.Split(' ');
                if (commands1.Length < 3 || commands1.Length>5) { continue; }
              //  Console.WriteLine(singer);
                string city = "";

                for (int i = 0; i < commands1.Length-2; i++)
                {
                    if (i != commands1.Length - 3)
                        city = city + commands1[i] + " ";
                    else
                        city = city + commands1[i];

                }
             //  Console.WriteLine(city);

                long ticketpricecount = long.Parse(commands1[commands1.Length - 1]);
                long ticketprice= long.Parse(commands1[commands1.Length - 2]);

                long totalprice = ticketpricecount * ticketprice;

                if(!cities.ContainsKey(city))
                {
                    cities.Add(city, new Dictionary<string, long>());
                    cities[city].Add(singer,totalprice);
                }
                else
                {
                    Dictionary<string, long> dictionary = cities[city];

                    if (!dictionary.ContainsKey(singer))
                    {
                        dictionary[singer] =totalprice;

                        cities[city] = dictionary;
                    }
                    else
                    {
                        dictionary[singer] = dictionary[singer] + totalprice;

                        cities[city] = dictionary;
                    }

                }

            }


            foreach (var item in cities)
            {
                var key = item.Key;
                Console.WriteLine(key);

                var value = item.Value;

                foreach (var item1 in value.OrderByDescending(a=>a.Value))
                {
                
                    Console.WriteLine($"#  {item1.Key} -> {item1.Value}");
                }

            }
        }
    }
}
