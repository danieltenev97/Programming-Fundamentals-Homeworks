using System;
using System.Text.RegularExpressions;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> planets = new Dictionary<string, List<string>>();

            planets.Add("Attacked", new List<string>());
            planets.Add("Destroyed", new List<string>());

            string pattern = @"[starSTAR]";
            Regex regex = new Regex(pattern);
            /*  
               string planetpattern = @"@([A-z]+)";
               string populationpattern = @":([0-9]+)";
               string modepattern = @"!([AD]{1})!";
               string countpatter = @"->([0-9]*)";


              
               Regex regex1 = new Regex(planetpattern);
               Regex regex2 = new Regex(populationpattern);
               Regex regex3 = new Regex(modepattern);
               Regex regex4 = new Regex(countpatter); */

            var patternmessage = @"^(|[^@>\->!,:]*)@([A-z]+)[^@>\->!,:]*:([0-9]+)[^@>\->!,:]*!([AD]){1}![^@>\->!,:]*->([0-9]+)[^@>\->!,:]*$";
            Regex message = new Regex(patternmessage);

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                MatchCollection matches = regex.Matches(input);
                int smallleterscount = matches.Count;
                var inputarr = input.ToCharArray();
             

                  for (int j = 0; j < inputarr.Length; j++)
                  {
                      int letterASCI = (int)inputarr[j];
                      char letter = inputarr[j];
                      letterASCI = letterASCI - smallleterscount;
                      char newletter = (char)letterASCI;

                      inputarr[j] = newletter;


                  }

               
               // string scriptedmessage = string.Join("", inputarr);

                StringBuilder scriptedmessage = new StringBuilder();
               
                foreach (var item in inputarr)
                {
                    scriptedmessage.Append(item);
                }


                // Match planetmatch = regex1.Match(scriptedmessage);
                // Match modematch = regex3.Match(scriptedmessage);

                Match planetmatch = message.Match(scriptedmessage.ToString());
               
                bool matchmessage = message.IsMatch(scriptedmessage.ToString());

                if(matchmessage==false)
                {
                    continue;
                }
              
               

                string planetName = planetmatch.Groups[2].Value;
                string mode = planetmatch.Groups[4].Value;

                if(mode=="A")
                {
                    if(!planets["Attacked"].Contains(planetName))
                    planets["Attacked"].Add(planetName);
                }
                else
                {
                    if(!planets["Destroyed"].Contains(planetName))
                    planets["Destroyed"].Add(planetName);
                }
                
                

            }

            foreach (var item in planets)
            {
                Console.WriteLine($"{item.Key} planets: {item.Value.Count}");

                var planetnames = item.Value;
                if(planetnames.Count!=0)
                {
                    foreach (var item1 in planetnames.OrderBy(x=>x))
                    {
                        Console.WriteLine($"-> {item1}");
                    }
                }
            }
        }
    }
}
