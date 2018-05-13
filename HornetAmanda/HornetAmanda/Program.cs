using System;
using System.Collections.Generic;
using System.Linq;

namespace HornetAmanda
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, long> legionActivity = new Dictionary<string, long>();
           
            Dictionary<string, Dictionary<string, long>> legions
                = new Dictionary<string, Dictionary<string, long>>();


            for (int i = 0; i <n; i++)
            {
                var commands = Console.ReadLine()
                    .Split(new[] { ":", " = ", " -> " }, StringSplitOptions.RemoveEmptyEntries);
                long lastactvity = long.Parse(commands[0]);
                long soldiercount = long.Parse(commands[3]);
                string legionname = commands[1];
                string soldiertype = commands[2];

                if(!legions.ContainsKey(legionname))
                {
                    legions.Add(legionname, new Dictionary<string, long>());
                    legions[legionname].Add(soldiertype, soldiercount);
                    legionActivity[legionname] = lastactvity;
                   
                }
                else
                {

                    if (!legions[legionname].ContainsKey(soldiertype))
                    {
                        legions[legionname].Add(soldiertype, soldiercount);
                        
                    }
                    else
                    {
                        legions[legionname][soldiertype] = legions[legionname][soldiertype]+soldiercount;
                       
                    }
                   
                        if(legionActivity[legionname]<lastactvity)
                        {
                            legionActivity[legionname] = lastactvity;
                        }
                    
                }

            }

            var input=Console.ReadLine().Split(new[] { '\\' },StringSplitOptions.RemoveEmptyEntries);
            if(input.Length==2)
            {
                long activity = long.Parse(input[0]);
                string soldier = input[1];

                foreach (var item in legions.Where(x=>x.Value.ContainsKey(soldier))
                    .OrderByDescending(x => x.Value[soldier]))
                {
                    var key = item.Key;
                    if(item.Value.ContainsKey(soldier))
                    {
                        if(legionActivity[key]<activity)
                        {
                            long count = item.Value[soldier];
                            Console.WriteLine($"{key} -> {count}");
                        }
                    }
                }
            }
            else if(input.Length==1)
            {
                string soldiertype = input[0];

                foreach (var item in legionActivity.OrderByDescending(x=>x.Value))
                {
                    var Legion = item.Key;
                    if(legions[Legion].ContainsKey(soldiertype))
                    {
                        Console.WriteLine($"{item.Value} : {Legion}");
                    }
                        
                }
            }
        }
    }
}
