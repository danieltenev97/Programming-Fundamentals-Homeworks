using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, List<string>> users
                = new SortedDictionary<string, List<string>>();
            Dictionary<string, Dictionary<string, int>> ipcount
                = new Dictionary<string, Dictionary<string, int>>();
           
            while(true)
            {
                string input = Console.ReadLine();
                if(input=="end") { break; }
                var commands = input
                    .Split(new[] {"IP=","message=","user="," " }, StringSplitOptions.RemoveEmptyEntries);

                string ip = commands[0];
                string user = commands[2];

                if(!users.ContainsKey(user))
                {
                    users.Add(user, new List<string>());
                    users[user].Add(ip);
                    ipcount.Add(user, new Dictionary<string, int>());
                    ipcount[user].Add(ip, 1);
                }
                else
                {
                    Dictionary<string, int> dictionary = ipcount[user];
                    users[user].Add(ip);

                    if (!dictionary.ContainsKey(ip))
                    {
                        dictionary[ip]=1;
                        ipcount[user] = dictionary;
                    }
                    else
                    {
                        dictionary[ip]++;
                        ipcount[user] = dictionary;
                    }
                }

                List<string> distinct = new List<string>();
                distinct.AddRange(users[user].Distinct());
                users[user] = distinct;
                
            }

             foreach (var item in users)
              {
                  var user = item.Key;
                  Console.WriteLine($"{user}:");
                  var value = item.Value;
                for (int i = 0; i < value.Count; i++)
                {
                    var dict = ipcount[user];
                    int counter = dict[value[i]];

                    if(i==value.Count-1)
                    {
                        Console.Write($"{value[i]} => {counter}. ");
                    }
                    else
                    {
                        Console.Write($"{value[i]} => {counter}, ");
                    }

                }

                Console.WriteLine();
              } 

      

         
        }
    }
}
