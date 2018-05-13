using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Trainlands
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> trains
                 = new Dictionary<string, Dictionary<string, long>>();

            while(true)
            {
                string input = Console.ReadLine();
                if(input.Equals("It's Training Men!")) { break; }

                var trainteams = input.Split(new[] { " -> ", " : ", " = " }, StringSplitOptions.RemoveEmptyEntries);

                if(trainteams.Length==3)
                {
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

                else 
                {
                    if(input.Contains("="))
                    {
                        string trainName = trainteams[0];
                        string othertrainName = trainteams[1];
                       
                        if (!trains.ContainsKey(trainName))
                        {
                            trains.Add(trainName, new Dictionary<string, long>());
                        }

                        trains[trainName].Clear();
                        foreach (var item in trains[othertrainName])
                        {
                            trains[trainName].Add(item.Key, item.Value);
                        }


                    }
                    else
                    {
                        string trainName = trainteams[0];
                        string othertrainName = trainteams[1];
                        if (!trains.ContainsKey(trainName))
                        {
                            trains.Add(trainName, new Dictionary<string, long>());
                        }
                       

                        foreach (var item in trains[othertrainName])
                        {
                            trains[trainName].Add(item.Key, item.Value);
                        }

                        trains.Remove(othertrainName);

                    }
                }
                       
            }

            foreach (var item in trains.OrderByDescending(x=>x.Value.Values.Sum())
                .ThenBy(x=>x.Value.Count()))
            {
                Console.WriteLine($"Train: {item.Key}");
                var wagons = item.Value;

                foreach (var item1 in wagons.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"###{item1.Key} - {item1.Value}");
                }
            }
        }
    }
}
