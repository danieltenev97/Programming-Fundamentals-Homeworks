using System;
using System.Collections.Generic;

namespace Magic_Exchangeable_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().ToLower().Split(' ');

            bool result = isExchangeable(input[0], input[1]);

            if(result==true)
            Console.WriteLine("true");
            else
                Console.WriteLine("false");
           
        }


        static bool isExchangeable(string a, string b)
        {
            bool a1=true;
            Dictionary<char, char> letters = new Dictionary<char, char>();

            var minLen = Math.Min(a.Length, b.Length);
            for (int i = 0; i <minLen; i++)
            {
                char first = a[i];
                char second = b[i];



               
                if (!letters.ContainsKey(first))
                {
                  

                    if (letters.ContainsValue(second))
                    {
                        return false;
                    }

                    letters[first] = second;
                }

                else
                {
                    char oldvalue = letters[first];
                    if (second != oldvalue)
                    {
                        a1 = false;
                    }
                }

            }

            if (a.Length != b.Length)
            {
                var longerStr = a.Length > b.Length ? a : b;
                var remainingLetters = longerStr.Substring(Math.Min(a.Length, b.Length));

                foreach (char letter in remainingLetters)
                {
                    if (!letters.ContainsKey(letter) && !letters.ContainsValue(letter))
                    {
                        return false;
                    }
                }
            }


            return a1;
        }
    }
}
