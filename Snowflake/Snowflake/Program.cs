using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Snowflake
{
    class Program
    {
        static void Main(string[] args)
        {
            // bool isValid = false;
            string surfacepattern = @"^[^A-Za-z0-9]+$";
            string mantlepattern = @"^[0-9_]+$";
            string totalpattern = @"^[^A-Za-z0-9]+[0-9_]+([A-Za-z]+)[0-9_]+[^A-Za-z0-9]+$";

            Regex surface = new Regex(surfacepattern);
            Regex mantle = new Regex(mantlepattern);
            Regex middle = new Regex(totalpattern);
            List<string> list = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                string input = Console.ReadLine();
                list.Add(input);
            }

            Match middlematch = middle.Match(list[2]);
            bool a = surface.IsMatch(list[0]);
            bool b = surface.IsMatch(list[4]);
            bool c = mantle.IsMatch(list[1]);
            bool d = mantle.IsMatch(list[3]);
            bool e = middle.IsMatch(list[2]);
            if(a==true&&b==true&&c==true&&d==true&&e==true)
            {
                Console.WriteLine("Valid");
                int size = middlematch.Groups[1].Value.Length;
                Console.WriteLine(size);
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            

        }
    }
}
