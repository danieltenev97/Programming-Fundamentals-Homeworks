using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace RainAir1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> flights
                = new Dictionary<string, List<int>>();

            var customerpattern = @"^[^= ]+$";

            Regex regex = new Regex(customerpattern);

            while(true)
            {
                string input = Console.ReadLine();
                if(input.Equals("I believe I can fly!")) { break; }
                var commands = input.Split(new[] { "="," "},StringSplitOptions.RemoveEmptyEntries);
                string passengerName = "";
                bool isCorrect = regex.IsMatch(commands[0]);
                if (isCorrect == false) continue;
              //  int result = 0;
                bool a = int.TryParse(commands[1], out int result);


                if(a==true)
                {
                    passengerName = commands[0];
                    var fLights = commands.Skip(1).Select(int.Parse).ToList();

                    if(!flights.ContainsKey(passengerName))
                    {
                        flights.Add(passengerName, new List<int>());
                    }
                    flights[passengerName].AddRange(fLights);
                }

                else
                {
                    passengerName = commands[0];
                    string secondpassenger = commands[1];
                    //flights[passengerName].Clear();

                    flights[passengerName] = new List<int>(flights[secondpassenger]);

                }
            }

            Dictionary<string, List<int>> sortedCustomers =
                flights
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in sortedCustomers)
            {
                var name = item.Key;
                var customersflights = item.Value.Distinct().OrderBy(x => x);

                Console.WriteLine($"#{name} ::: {string.Join(", ",customersflights)}");
            }

        }
    }
}
