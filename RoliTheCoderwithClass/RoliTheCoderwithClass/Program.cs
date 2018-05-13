using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoliTheCoderwithClass
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, Events> dictionaryevents = new Dictionary<int, Events>();

           

            while(true)
            {
                string input = Console.ReadLine();
                if (input == "Time for Code") break;

                List<string> events = new List<string>();
                bool beginsWith = true;
                var commands = Console.ReadLine()
                    .Split(new[] { " ", "\t" }, StringSplitOptions.RemoveEmptyEntries);

                var id = 0;
                bool res = int.TryParse(commands[0], out id);

                if(!res)
                {
                    continue;
                }

                string evname = commands[1];
                if(!evname.StartsWith("#"))
                {
                    continue;
                }

              evname = evname.Trim('#');

                for (int i = 2; i < commands.Length; i++)
                {
                    if(!commands[i].StartsWith("@"))
                    {
                    
                        beginsWith = false;
                        break;
                    }
                    events.Add(commands[i]);
                }
                if (beginsWith == false) { continue; }

      
             
                if(!dictionaryevents.ContainsKey(id))
                {
                    dictionaryevents.Add(id, new Events());

                    dictionaryevents[id].name = evname;
                    dictionaryevents[id].list=events;

                }
                else
                {
                    var existingName = evname;
                    if(existingName==dictionaryevents[id].name)
                    {
                        dictionaryevents[id].list.AddRange(events);
                     
                    }

                    else
                    {
                        continue;
                    }
                }


            }

            foreach (var item in dictionaryevents.OrderByDescending(a=>a.Value.list.Count)
                .ThenBy(a=>a.Value.name))
            {
                var value = item.Value.list;
                var key = item.Value.name;
                var sortedvalue = item.Value.list.Distinct().OrderBy(a => a).ToList();
                var count = sortedvalue.Count;
              

                Console.WriteLine($"{key} - {count}");
               
                foreach (var item1 in sortedvalue)
                {
                    Console.WriteLine(item1);
                }
            }
        }
    }
}
