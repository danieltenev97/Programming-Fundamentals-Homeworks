using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roli___The_Coder
{
    class Program                         //NE E Dovurshena !!!!!!!!!!!!!!!!
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> names = new Dictionary<int, string>();
            Dictionary<int, List<string>> devents = new Dictionary<int, List<string>>();
           

               while(true)
            {
                var input = Console.ReadLine();
                List<string> people = new List<string>();
                if (input == "Time for Code") break;

                var inputs=input.Split(new[] { " ", " \t" }, StringSplitOptions.RemoveEmptyEntries);

                int id =int.Parse(inputs[0]);
                string eventsname =inputs[1];

                if(!eventsname.StartsWith("#"))
                {
                    continue;
                }

                bool beginsWith = false;

                for (int i = 2; i < inputs.Length; i++)
                {
                    if (!inputs[i].StartsWith("@"))
                    {
                        beginsWith = true;
                        break;
                    }
                    people.Add(inputs[i]);
                }

                if(beginsWith==true)
                {
                    continue;
                }

                eventsname = eventsname.Trim('#');


            if(names.ContainsKey(id))
                {
                    var existingname = names[id];
                    if(eventsname==existingname)
                    {
                       
                        devents[id].AddRange(people);
                        
                    }
                        
                }

            else
                {
                    names[id] = eventsname;
                    devents.Add(id, new List<string>());
                    devents[id].AddRange(people);

                }

                

               }

           
            foreach (var item in devents.OrderByDescending(a=>a.Value.Count)
                .ThenBy(a=>names[a.Key]))
            {
                var key = item.Key;
                var eevents = names[key];

                var values = item.Value;
                
                var sorted = values.Distinct().OrderBy(a => a).ToList();
                Console.WriteLine($"{eevents} - {sorted.Count}");
                foreach (var item1 in sorted)
                {
                    Console.WriteLine($"{item1}");
                }
              
            }


        }
    }
}
