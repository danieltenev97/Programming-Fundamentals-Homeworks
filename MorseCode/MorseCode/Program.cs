using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace MorseCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('|').ToList();
            List<int> sums = new List<int>();
            int equalDigitsCount = 1;
            string patter = @"^[01]+$";
            Regex regex = new Regex(patter);

            foreach (var item in input)
            {
                string currentmessage = item;
                var zeroesCount = item.Count(x => x == '0');

                var onesCount = item.Count(x => x == '1');

                var currentSum = zeroesCount * 3 + onesCount * 5;

                if (!regex.IsMatch(currentmessage)) { continue; }

                equalDigitsCount = 1;
                for (int i = 0; i < item.Length - 1; i++)
                {
                    var currentDigit = item[i];
                    var nextDigit = item[i + 1];

                    if (currentDigit == nextDigit)
                    {
                        equalDigitsCount++;
                    }

                    else
                    {
                        if (equalDigitsCount == 1)
                        {
                            continue;
                        }

                        currentSum += equalDigitsCount;
                        equalDigitsCount = 1;
                    }

                    if (equalDigitsCount != 1)
                    {
                        currentSum += equalDigitsCount;
                    }


                }
                sums.Add(currentSum);
            }
            StringBuilder mybuilder = new StringBuilder();

            foreach (var item in sums)
            {
                char symbol = (char)item;

                mybuilder.Append(symbol);
            }

            Console.WriteLine(mybuilder);

        }
    }
}
