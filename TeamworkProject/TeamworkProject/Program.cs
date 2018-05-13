using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamworkProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberteams = int.Parse(Console.ReadLine());
            List<Teams> teams = new List<Teams>();

            for (int i = 0; i < numberteams; i++)
            {
                var input = Console.ReadLine().Split('-').ToArray();
                bool contains = false;
                string creator = input[0];
                string teamname = input[1];

               

              
                    if(teams.Any(x=>x.name==teamname))
                    {
                        contains = true;
                        Console.WriteLine($"Team {teamname} was already created!");
                        
                    }
                    else if(teams.Any(x=>x.creator==creator))
                   {
                      contains = true;
                        Console.WriteLine($"{creator} cannot create another team!");
                        

                    } 
                    
                 

                if(contains!=true)
                {
                    var currentteam = new Teams();
                    currentteam.creator = creator;
                    currentteam.name = teamname;
                    currentteam.members = new List<string>();
                    Console.WriteLine($"Team {teamname} has been created by {creator}!");
                    teams.Add(currentteam);
                }

            }

        while(true)
            {
                string input = Console.ReadLine();
                if(input== "end of assignment") { break; }
                bool containsteam = false;
                bool containscreator =false;
                bool containsmember = false;
                var commands = input.Split(new[] { "->" }, StringSplitOptions.RemoveEmptyEntries);
                string name = commands[0];
                string teamname = commands[1];
                var currentteam = new Teams();
                
                
               
                foreach (var item in teams )
                {
                    if(item.name==teamname)
                    {
                       
                        containsteam = true;
                        
                        
                    }

                     if(item.creator==name)
                    {
                        
                         containscreator = true;
                        
                    }
                  

                  if(item.members.Contains(name))
                    {
                      
                        containsmember = true;
                        
                    }

                   }

                if(containsteam==false)
                {
                    Console.WriteLine($"Team {teamname} does not exist!");
                }
              else if(containscreator==true&&containsteam==true)
                {
                    Console.WriteLine($"Member {name} cannot join team {teamname}!");
                    
                }
              else  if(containsmember==true)
                {
                    Console.WriteLine($"Member {name} cannot join team {teamname}!");
                }

                if(containsteam==true&&containscreator==false&&containsmember==false)
                {
                    foreach (var item in teams)
                    {
                        if(item.name==teamname)
                        {
                            item.members.Add(name);
                        }
                    }
                }


            }

            foreach (var item in teams.OrderByDescending(a=>a.members.Count).ThenBy(x=>x.name))
            {
                var valuemembers = item.members;
                if(valuemembers.Count!=0)
                {
                    Console.WriteLine(item.name);
                    Console.WriteLine($"- {item.creator}");
                    foreach (var item1 in valuemembers.OrderBy(x=>x))
                    {
                        Console.WriteLine($"-- {item1}");
                    }
                }

            }

            Console.WriteLine("Teams to disband:");
            foreach (var item in teams.OrderBy(x => x.name))
            {
                var valuemembers = item.members;
                if (valuemembers.Count == 0)
                {
                    Console.WriteLine(item.name);
                }
            }
        }
    }
}
