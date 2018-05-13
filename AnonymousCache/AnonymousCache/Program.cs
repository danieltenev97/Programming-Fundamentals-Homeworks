using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace AnonymousCache
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> database = new Dictionary<string, Dictionary<string, long>>();

            Dictionary<string, Dictionary<string, long>> cache = new Dictionary<string, Dictionary<string, long>>();
           
           
            while(true)
            {
                string input = Console.ReadLine();
                if(input== "thetinggoesskrra") { break; }

                var commands = input.Split(new[] { " -> "," | " }, StringSplitOptions.RemoveEmptyEntries);
                
                
                string dataset = "";
                string datekey = "";
                long datasize = 0;

                if (commands.Length == 1)
                {
                    dataset = commands[0];

                    if (!database.ContainsKey(dataset))
                    {
                        database.Add(dataset, new Dictionary<string, long>());

                        if (cache.ContainsKey(dataset))
                        {
                            foreach (var item in cache[dataset])
                            {
                                if (!database.ContainsKey(item.Key))
                                {
                                    database[dataset][item.Key] = item.Value;
                                }
                            }
                        }
                    }
                }
                else if (commands.Length == 3)
                {
                    datekey = commands[0].Trim();
                    dataset = commands[2].Trim();
                    datasize = long.Parse(commands[1]);
                    if (!database.ContainsKey(dataset))
                    {
                        if (!cache.ContainsKey(dataset))
                        {
                            cache.Add(dataset, new Dictionary<string, long>());
                        }

                        cache[dataset][datekey] = datasize;
                    }
                    else
                    {
                        database[dataset][datekey] = datasize;
                    }
                }
                


            }

            if(database.Count==0)
            {
                return;
            }


            Dictionary<string, long> maxsize = new Dictionary<string, long>();
            
            foreach (var item in database)
            {
                long b = item.Value.Sum(x=>x.Value);
                maxsize[item.Key] = b;
            }

            foreach (var item in maxsize.OrderByDescending(x=>x.Value))
            {
                Console.WriteLine($"Data Set: {item.Key}, Total Size: {item.Value}");
                var value = database[item.Key];
                foreach (var item1 in value)
                {
                    Console.WriteLine($"$.{item1.Key}");
                }
                break;
            }

        }
    }
}
