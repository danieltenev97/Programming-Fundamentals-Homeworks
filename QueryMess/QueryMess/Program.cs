using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace QueryMess
{
    class Program
    {
        static void Main(string[] args)
        {

         
            string fieldpattern = @"([^=?&\n]+)=([^=?&\n]+)";
            Regex regex = new Regex(fieldpattern);

            

            while (true)
            {
                Dictionary<string, List<string>> keypairs = new Dictionary<string, List<string>>();
                string input = Console.ReadLine();
                if(input=="END") { break; }

                string spacepattern = @"(%20|\+)+";

                MatchCollection keymatch = regex.Matches(input);
               

                foreach (Match item in keymatch)
                {
                    string KEY = item.Groups[1].Value;
                    KEY = Regex.Replace(KEY, spacepattern, " ").Trim();
                    string value = item.Groups[2].Value;

                    value = Regex.Replace(value, spacepattern, " ").Trim();

                    if (!keypairs.ContainsKey(KEY))
                    {
                        keypairs.Add(KEY, new List<string>());
                    }

                    keypairs[KEY].Add(value);

                    
                }


                foreach (var item in keypairs)
                {
                    Console.Write($"{item.Key}=[{string.Join(", ",item.Value)}]");
                }

                Console.WriteLine();
            }
        }
    }
}
