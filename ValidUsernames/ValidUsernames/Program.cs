using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;


namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> validusernames = new List<string>();
            var input = Console.ReadLine().Split(new[] { '\\', '/', '(', ')', ' ', ',' }
            , StringSplitOptions.RemoveEmptyEntries);

            string usernames = string.Join(" ", input);
            string pattern = @"(^| )[A-Za-z]([A-za-z0-9\-]){2,24}\b";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(usernames);

            foreach (Match item in matches)
            {
                validusernames.Add(item.Value.Trim());
            }

            int sum = 0;
            int maxsum = 0;
            string firstmatch = "";
            string secondmatch = "";

            for (int i = 0; i <validusernames.Count-1; i++)
            {
                int first = validusernames[i].Length;
                int second = validusernames[i + 1].Length;
                sum = first + second;

                if(sum>maxsum)
                {
                    maxsum = sum;
                    firstmatch = validusernames[i];
                    secondmatch = validusernames[i + 1];
                }
            }

            Console.WriteLine(firstmatch);
            Console.WriteLine(secondmatch);
            
       }
    }
}
