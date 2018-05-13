using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
              
            List<Dwarf> dwarves = new List<Dwarf>();
            Dictionary<string, List<Dwarf>> dictionary = new Dictionary<string, List<Dwarf>>();
            while(true)
            {
                string input = Console.ReadLine();
                if(input== "Once upon a time")
                { break; }
                var dWarf = new Dwarf();
                var info = input.Split(new[] { " ", "<:>" }, StringSplitOptions.RemoveEmptyEntries);
                int count = 1;
                var colour = info[1];
                var name = info[0];
                int stregth = int.Parse(info[2]);

            
                int a = 0;
                if (dwarves.Count != 0)
                {
                    foreach (var item in dwarves)
                    {
                        var itemcolour = item.colour;
                        var itemname = item.name;
                        var itemphysics = item.physics;
                        if (colour == itemcolour && name == itemname)
                        {
                            if (stregth >= itemphysics)
                            {
                                item.physics = stregth;
                                
                                
                            }
                            a++;
                        }

                        else if(colour==item.colour&& name != itemname)
                        {
                           count = item.count + 1;
                        }
                    }
                }

                if (a != 0) continue;

                dWarf.name = name;
                dWarf.colour = colour;
                dWarf.physics = stregth;
                dWarf.count = count;

                
                if (!dictionary.ContainsKey(colour))
                {
                    dictionary.Add(colour, new List<Dwarf>());
                   
                }

                var dwarfbycurrentcolour = dictionary[colour];

                dwarfbycurrentcolour.Add(dWarf);


                dwarves.Add(dWarf);

            }

           

            foreach (var item in dwarves.OrderByDescending(a=>a.physics)
                .ThenByDescending(b=>dictionary[b.colour].Count()))
            {
                var itemname = item.name;
                var itemcolour = item.colour;
                var itemphysics = item.physics;
                Console.WriteLine($"({itemcolour}) {itemname} <-> {itemphysics}");
            } 

            

        }
    }
}
