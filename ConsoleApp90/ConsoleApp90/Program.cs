using System;
using System.Collections.Generic;

namespace ConsoleApp90
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> trains
                  = new Dictionary<string, Dictionary<string, long>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input.Equals("It's Training Men!")) { break; }

                var trainteams = input.Split(' ');
                string trainName = trainteams[0];
                string wagon = trainteams[1];
                long wagonpower = long.Parse(trainteams[2]);

                if (!trains.ContainsKey(trainName))
                {
                    trains.Add(trainName, new Dictionary<string, long>());
                    trains[trainName][wagon] = wagonpower;
                }

                trains[trainName][wagon] = wagonpower;


            }

            trains["Daniel"] = trains["Gosho"];
        }
    }
}
