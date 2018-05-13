using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace CameraView
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[2];
            arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<string> photos = new List<string>();
            int take = arr[1];
            int skip = arr[0];

            string pattern = @"\|<[\S]*";
            string input = Console.ReadLine();
            Regex regex = new Regex(pattern);

            MatchCollection mathes = regex.Matches(input);

            foreach (Match item in mathes)
            {
                var value = item.Value;

                var takelist = value.Split(new[] { "|<" }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var item1 in takelist)
                {
                    int leftcount = item1.Length - skip;
                    int take1 = take;
                    if(take1>leftcount)
                    {
                        take1 = leftcount;
                    }

                    var a = item1.Skip(skip).Take(take1);

                    string b = string.Join("", a);
                    photos.Add(b);
                }

            }

            Console.WriteLine(string.Join(", ",photos));


        }
    }
}
