using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;


namespace DragonArmy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, SortedDictionary<string, Dictionary<string, int>>> dragon
                = new Dictionary<string, SortedDictionary<string, Dictionary<string, int>>>();



            for (int i = 0; i <n ; i++)
            {
                var input = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                var nullindex = new List<int>();

                for (int j = 0; j <input.Length; j++)
                {
                    if(input[j]=="null")
                    {
                        nullindex.Add(j);
                    }
                }

                string dragontype = input[0];
                string dragonname = input[1];
                string dname = "damage";
                string hname = "health";
                string aname = "armor";


                int damage = 0;
                int health = 0;
                int armor = 0;

                if(input[2]!="null")
                {
                    damage = int.Parse(input[2]);

                }
                if (input[3] != "null")
                {
                    health = int.Parse(input[3]);

                }
                if (input[4] != "null")
                {
                    armor = int.Parse(input[4]);

                }

              foreach (var item in nullindex)
                {
                    if(item==input.Length-1)
                    {
                        armor = 10;
                    }
                    if (item == input.Length - 2)
                    {
                        health = 250;
                    }
                    if (item == input.Length - 3)
                    {
                        damage = 45;
                    }
                }

                if(!dragon.ContainsKey(dragontype))
                {
                    dragon.Add(dragontype, new SortedDictionary<string, Dictionary<string, int>>());
                    dragon[dragontype].Add(dragonname, new Dictionary<string, int>());
                }

                if(dragon.ContainsKey(dragontype))
                {
                    if(!dragon[dragontype].ContainsKey(dragonname))
                    {
                        dragon[dragontype].Add(dragonname, new Dictionary<string, int>());
                    }

                    
                }

                dragon[dragontype][dragonname][dname] = damage;
                dragon[dragontype][dragonname][hname] = health;
                dragon[dragontype][dragonname][aname] = armor;



            }

            foreach (var item in dragon)
            {
                double damageaverage = 0;
                double healthaverage = 0;
                double aromoraverage = 0;
                var average = item.Value;
                foreach (var item1 in average)
                {
                    var key = item1.Key;
                    damageaverage = damageaverage + average[key]["damage"];
                    healthaverage= healthaverage + average[key]["health"];
                    aromoraverage= aromoraverage + average[key]["armor"];


                }

                int count = average.Count;
                damageaverage = damageaverage / count;
                healthaverage = healthaverage / count;
                aromoraverage = aromoraverage / count;

                Console.WriteLine($"{item.Key}::({damageaverage:F2}/{healthaverage:F2}/{aromoraverage:F2})");
                int currentdamage = 0;
                int currenthealth = 0;
                int currentarmor = 0;
                foreach (var names in average)
                {
                    var dragonName = names.Key;
                    var characteristics = names.Value;

                    currentdamage = characteristics["damage"];
                    currenthealth = characteristics["health"];
                    currentarmor = characteristics["armor"];
                    Console.WriteLine($"-{dragonName} -> damage: {currentdamage}, health: {currenthealth}, armor: {currentarmor}");
                }

                
            }
        }
    }
}
