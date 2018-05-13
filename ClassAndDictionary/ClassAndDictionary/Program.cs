using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, First> dictionary = new Dictionary<string, First>();

            List<int> list = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                list.Add(i);
            }

            dictionary["primer"] = new First()
            {
                number = list
            };

            int j = 0;

            while(j<3)
            {

                string input = Console.ReadLine();
                var list1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                if(dictionary.ContainsKey(input))
                {                                         //AddRange -> dobavq vsichko navednuj
               dictionary[input].number.AddRange(list1); //добавям нови елементи в съществуващия списък на класа 
                }
                j++;
            }

            foreach (var item in dictionary)
            {
                var key = item.Key;
                var value = item.Value.number;
                var sorted = value.Distinct().OrderByDescending(a => a).ToList(); // pravq nov spipuk ot stariq
                                                                                 // bez povtoreniq na elementi
                Console.WriteLine(key);
                foreach (var item1 in sorted)
                {
                    Console.Write(item1+ " ");
                }
            }
        }
    }
}
