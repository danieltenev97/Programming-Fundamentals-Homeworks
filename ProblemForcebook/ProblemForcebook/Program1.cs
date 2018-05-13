using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemForcebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> firstSide = new Dictionary<string, List<string>>();
        
            Dictionary<string, string> soldiers = new Dictionary<string, string>();

            string splitter = " | ";
            string splitter1 = " -> ";

           while(true)
            {
                string input = Console.ReadLine();
                if(input=="Lumpawaroo") { break; }
                if(input.Contains(splitter))
                {
                    var command = input.Split(new[] { splitter }, StringSplitOptions.RemoveEmptyEntries);
                    var forceSide = command[0];
                    var forceUser = command[1];

                    if(!soldiers.ContainsKey(forceUser))
                    {
                        soldiers[forceUser] = forceSide;
                        if(!(firstSide.ContainsKey(forceSide)))
                        {
                            firstSide.Add(forceSide, new List<string>());
                            firstSide[forceSide].Add(forceUser);
                        }

                        else
                        {
                            firstSide[forceSide].Add(forceUser);
                        }

                    }
                    
                }

               else if(input.Contains(splitter1))
                {
                    var command = input.Split(new[] { splitter1 }, StringSplitOptions.RemoveEmptyEntries);
                    var forceSide = command[1];
                    var forceUser = command[0];

                    if(!soldiers.ContainsKey(forceUser))
                    {
                        soldiers[forceUser] = forceSide;
                        if (!(firstSide.ContainsKey(forceSide)))
                        {
                            firstSide.Add(forceSide, new List<string>());
                            firstSide[forceSide].Add(forceUser);
                        }

                        else
                        {
                            firstSide[forceSide].Add(forceUser);
                        }

                    }

                    else
                    {
                        soldiers[forceUser] = forceSide;

                        foreach (var item in firstSide)
                        {
                            var value = item.Value;
                            if(value.Contains(forceUser))
                            {
                                value.Remove(forceUser);
                            }
                           
                            
                        }
                        if (!(firstSide.ContainsKey(forceSide)))
                        {
                            firstSide.Add(forceSide, new List<string>());
                            firstSide[forceSide].Add(forceUser);
                        }

                        else
                        {
                            firstSide[forceSide].Add(forceUser);
                        }

                      

                    }
                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                }
            }


            foreach (var item in firstSide.OrderByDescending(a=>a.Value.Count).ThenBy(a=>a.Key))
            {
                var key = item.Key;
                var value = item.Value;
                if (value.Count == 0) continue;

                Console.WriteLine($"Side: {key}, Members: {value.Count}");

                foreach (var item1 in value.OrderBy(a=>a))
                {
                    Console.WriteLine($"! {item1}");
                }



            }


       }
    }
}
