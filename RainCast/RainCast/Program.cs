using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RainCast
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> forecasts
                 = new Dictionary<string, Dictionary<string, string>>();
          //  forecasts.Add("Normal", new Dictionary<string, string>());
          //  forecasts.Add("Danger", new Dictionary<string, string>());
          //  forecasts.Add("Warning", new Dictionary<string, string>());

            string typepattern = @"^(Normal|Danger|Warning)$";
            string sourcepattern = @"^[A-Za-z0-9]+$";
            string forecastpattern = @"^[^\.,?!]+$";

            Regex regextype = new Regex(typepattern);
            Regex source = new Regex(sourcepattern);
            Regex forecastregex = new Regex(forecastpattern);

            List<string> inputcommands = new List<string>();

            while(true)
            {
                string input = Console.ReadLine();
                if(input== "Davai Emo") { break; }
                var commands = input.Split(new[] {": " },StringSplitOptions.RemoveEmptyEntries);
                

                string command = commands[0];
                
                if(command.Equals("Type"))
                {
                    bool isMatch = regextype.IsMatch(commands[1]);
                    if(isMatch==false) { continue; }
                    
                    if(inputcommands.Count==0)
                    {
                        inputcommands.Add(commands[1]);
                    }
                    

                }

                if(command.Equals("Source"))
                {
                    
                    bool isMatch = source.IsMatch(commands[1]);
                    if (isMatch == false) { continue; }


                    if (inputcommands.Count == 1)
                    {
                        inputcommands.Add(commands[1]);
                    }
                }
                if(command.Equals("Forecast"))
                {
                    
                    bool isMatch = forecastregex.IsMatch(commands[1]);
                    if (isMatch == false) { continue; }


                    if (inputcommands.Count == 2)
                    {
                        inputcommands.Add(commands[1]);
                    }
                }

                if(inputcommands.Count==3)
                {
                    string type = inputcommands[0];
                    string sOurce = inputcommands[1];
                    string foreCast = inputcommands[2];

                    if(!forecasts.ContainsKey(type))
                    {
                        forecasts.Add(type, new Dictionary<string, string>());
                    }

                    forecasts[type][sOurce] = foreCast;

                    inputcommands.Clear();
                }

             }

            foreach (var item in forecasts)
            {
                var type = item.Key;
                foreach (var item1 in item.Value)
                {
                    var Source = item1.Key;
                    var foreCast = item1.Value;
                    Console.WriteLine($"({type}) {foreCast} ~ {Source}");
                }
            }

        }
    }
}
