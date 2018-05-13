using System;
using System.Collections.Generic;
using System.Linq;

namespace CODEPhoenix
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> creatures = new Dictionary<string, List<string>>();
            Dictionary<string, int> squadsize = new Dictionary<string, int>();

            while(true)
            {
                string input = Console.ReadLine();
                if(input== "Blaze it!") { break; }
               
                var inputcreatures = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                string squadname = inputcreatures[0];
                string squadMate = inputcreatures[1];
             
               
                if(squadname==squadMate) { continue; }

                if(!creatures.ContainsKey(squadname))
                {
                    creatures.Add(squadname, new List<string>());
                }
                else
                {
                 if(creatures[squadname].Contains(squadMate)) { continue; }
                }

                creatures[squadname].Add(squadMate);
            }


            foreach (var item in creatures)
            {
                int size = item.Value.Count();
                var value1 = item.Value;
             //   bool contains = false;
                foreach (var item1 in creatures.Where(x=>x.Key!=item.Key))
                {

                    var key = item1.Key;
                    var value = item1.Value;
                    if(value.Contains(item.Key)&&value1.Contains(key))
                    {
                        size--;
                        
                    }

                
                } 
              //  if(size<0)
              //  {
               //     size = 0;
              //  }
                squadsize[item.Key] = size;
            }

            foreach (var item in squadsize.OrderByDescending(x=>x.Value))
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }
    }
}
