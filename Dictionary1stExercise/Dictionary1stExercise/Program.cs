using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary1stExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> footballplayer = new Dictionary<string, int>();

            footballplayer["Hazard"] = 10;
            footballplayer["Morata"] = 9;
           
            int sum = footballplayer["Hazard"] + footballplayer["Morata"];

            Console.WriteLine(sum);

            foreach (var item in footballplayer)
            {
                Console.WriteLine(item.Key+" "+ item.Value);
            }
           

           

            Dictionary<string, List<int>> dictionaryoflists = new Dictionary<string, List<int>>();

            dictionaryoflists["First"] = new List<int>();
            dictionaryoflists["Second"] = new List<int>();
            dictionaryoflists["Second"].Add(5);
            dictionaryoflists["Second"].Add(3);
            dictionaryoflists["Second"].Add(4);
            dictionaryoflists["Second"].Sort();
            dictionaryoflists["Third"] = new List<int>();
            sum = 0;
            List<int> newlist = dictionaryoflists["Second"];
            newlist.Add(7);
            newlist.Reverse();
            foreach (var item in dictionaryoflists)
            {
                Console.WriteLine(item.Key);
                foreach (var item1 in item.Value)
                {
                    Console.WriteLine(item1);
                }
            }


            
        }
    }
}
