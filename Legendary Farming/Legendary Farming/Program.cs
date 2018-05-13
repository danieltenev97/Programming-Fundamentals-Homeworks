using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> specialmaterials = new Dictionary<string, int>();
            SortedDictionary<string, int> junkmaterials = new SortedDictionary<string, int>();
            Dictionary<string, string> legendary = new Dictionary<string, string>
            {
                ["fragments"] = "Valanyr",
                ["shards"] = "Shadowmourne",
                ["motes"] = "Dragonwrath"
            };
            bool stop = false;
            while (true)
            {
                var commands = Console.ReadLine().ToLower()
                    .Split().ToArray();
                    
                var materials1 = commands.Where((x, i) => i % 2 == 1).ToArray();
                var quantities = commands.Where((x, i) => i % 2 == 0).Select(int.Parse).ToArray();

                for (int i = 0; i <materials1.Length; i++)
                {
                    string material = materials1[i];
                    int quantity = quantities[i];
                    if (specialmaterials.ContainsKey("fragments"))
                    {
                        if (specialmaterials["fragments"] >= 250)
                        {
                            specialmaterials["fragments"] = specialmaterials["fragments"] - 250;
                            Console.WriteLine($"Valanyr obtained!");
                            stop = true;
                            break;
                        }
                    }
                    if (specialmaterials.ContainsKey("shards"))
                    {
                        if (specialmaterials["shards"] >= 250)
                        {
                            specialmaterials["shards"] = specialmaterials["shards"] - 250;
                            Console.WriteLine($"Shadowmourne obtained!");
                            stop = true;
                            break;
                        }
                    }
                    if (specialmaterials.ContainsKey("motes"))
                    {
                        if (specialmaterials["motes"] >= 250)
                        {
                            specialmaterials["motes"] = specialmaterials["motes"] - 250;
                            Console.WriteLine($"Dragonwrath obtained!");
                            stop = true;
                            break;
                        }
                    }
                    if (legendary.ContainsKey(material))
                    {
                        if(!specialmaterials.ContainsKey(material))
                        {
                            specialmaterials[material] = quantity;
                        }
                        else
                        {
                            specialmaterials[material] += quantity;
                        }
                    }
                    else
                    {
                        if (!junkmaterials.ContainsKey(material))
                        {
                            junkmaterials[material] = quantity;
                        }
                        else
                        {
                            junkmaterials[material] += quantity;
                        }

                    }
                }

                if (stop == true) { break; }

              

            }

            foreach (var item in legendary)
            {
                var key = item.Key;
                if(!specialmaterials.ContainsKey(key))
                {
                    specialmaterials.Add(key, 0);
                }
            }

            foreach (var item in specialmaterials.OrderByDescending(a=>a.Value).ThenBy(a=>a.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            

            foreach (var item in junkmaterials)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            
        }
    }
}
