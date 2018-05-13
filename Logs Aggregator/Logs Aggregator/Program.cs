using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, List<string>> user = new SortedDictionary<string, List<string>>();
            SortedDictionary<string, int> durationuser = new SortedDictionary<string, int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                string ip = input[0];
                string username = input[1];
                int duration = int.Parse(input[2]);

                if(!user.ContainsKey(username))
                {
                    user.Add(username, new List<string>());
                    user[username].Add(ip);

                    durationuser[username] = duration;
                }

                else
                {
                    if(!user[username].Contains(ip))
                        {
                        user[username].Add(ip);
                    }

                    durationuser[username] += duration;
                }

            }
            
            foreach (var item in user)
            {
                int duration = 0;
                foreach (var item1 in durationuser)
                {
                    if(item.Key==item1.Key)
                    {
                        duration = item1.Value;
                    }
                }

                var value = item.Value;
                var sortvalue = value.OrderBy(a => a).ToList();
                Console.WriteLine($"{item.Key}: {duration} [{string.Join(", ",sortvalue)}]");
              
                

            }

        }
    }
}
