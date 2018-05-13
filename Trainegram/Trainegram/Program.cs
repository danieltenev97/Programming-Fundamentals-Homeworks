using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace Trainegram
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^(<\[[^A-Za-z0-9]*\].)(\.\[[A-Za-z0-9]*\].)*$";

            Regex regex = new Regex(pattern);

            List<string> textmatches = new List<string>();

            while(true)
            {
                string input = Console.ReadLine();
                if(input== "Traincode!") { break; }
                

                bool isValid = regex.IsMatch(input);
                if(isValid==false) { continue; }

                textmatches.Add(input);

                
            }

            foreach (var item in textmatches)
            {
                Console.WriteLine(item);
            }
        }
    }
}
