using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<string, Dictionary<string, int>> dictionary = new Dictionary<string, Dictionary<string, int>>();

            dictionary.Add("Tenevi", new Dictionary<string, int>());

            dictionary["Tenevi"].Add("Daniel", 20);
            dictionary["Tenevi"].Add("Yordan", 59);

            Dictionary<string, List<int>> players = new Dictionary<string, List<int>>();

            players.Add("Chelsea", new List<int>());

            players["Chelsea"].Add(10);
            players["Chelsea"].Add(11);
            players["Chelsea"].Add(19);
            players["Chelsea"].Add(15);
            players["Chelsea"].Add(25);
            players["Chelsea"].Add(5);

            players.Add("Bayern", new List<int>());
            players["Bayern"].Add(21);
            players["Bayern"].Add(24);

           
            var sum = 0;
            foreach (var item in players)
            {
                var keyv = item.Value;

                foreach (var item1 in keyv)
                {
                  
                    sum = item1 + sum;
                 
                }
                Console.WriteLine(sum);
                sum = 0;
            }
            

            foreach (var item in dictionary)
            {
                var keyv = item.Value;

                foreach (var item1 in keyv)
                {
                    Console.WriteLine(item1);
                }
            }

            
        }
    }
}
