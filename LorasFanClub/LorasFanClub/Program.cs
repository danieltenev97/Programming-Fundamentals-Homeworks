﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LorasFanClub
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, Dictionary<string, long>> boys
                = new Dictionary<string, Dictionary<string, long>>();

            while(true)
            {
                string input = Console.ReadLine();

               if(input== "Make a decision already!") { break; }

                var commands = input.Split();

                string name = commands[0];

                if (commands[1] == "does")
                {
                    if(!boys.ContainsKey(name)) { continue; }
                    Dictionary<string, long> remaining = new Dictionary<string, long>();

                    foreach (var item in boys[name])
                    {
                        var value = item.Value;
                        if(value<0)
                        {
                            remaining[item.Key] = value;
                        }
                    }

                    boys[name].Clear();
                    boys[name] = remaining;
                }
                else
                {
                    string trait = commands[1];
                    long traitValue = long.Parse(commands[2]);

                    switch (trait)
                    {
                        case "Greedy":
                            traitValue = -traitValue;
                            break;
                        case "Rude":
                            traitValue = -traitValue;
                            break;
                        case "Dumb":
                            traitValue = -traitValue;
                            break;
                        case "Kind":
                            traitValue = traitValue * 2;
                            break;
                        case "Handsome":
                            traitValue = traitValue * 3;
                            break;
                        case "Smart":
                            traitValue = traitValue * 5;
                            break;
                        default:
                            break;
                    }

                    if (!boys.ContainsKey(name))
                    {
                        boys.Add(name, new Dictionary<string, long>());
                        boys[name][trait] = traitValue;
                    }

                    else
                    {
                        if (boys[name].ContainsKey(trait))
                        {
                            if (boys[name][trait] < traitValue)
                            {
                                boys[name][trait] = traitValue;
                            }
                        }
                        else
                        {
                            boys[name][trait] = traitValue;
                        }
                    }
                }

            }

            foreach (var boy in boys.OrderByDescending(x => x.Value.Sum(a => a.Value)).ThenBy(x => x.Key))
            {
                var name = boy.Key;
                var sumqualities = boy.Value.Sum(x => x.Value);
                Console.WriteLine($"# {name}: {sumqualities}");

                var value = boy.Value.OrderByDescending(x => x.Value);

                foreach (var item in value)
                {
                    if (item.Value != 0)
                        Console.WriteLine($"!!! {item.Key} -> {item.Value}");
                }

            }

        }
    }
}
