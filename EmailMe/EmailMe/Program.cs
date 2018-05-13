using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace EmailMe
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();

            string pattern = @"([A-Za-z]+)\@([A-Za-z]+)";

            Regex regex = new Regex(pattern);

            Match match = regex.Match(email);
            string usename = match.Groups[1].Value;
            string host = match.Groups[2].Value;

            int usernamesum = 0;
            int hostsum = 0;

            for (int i = 0; i < usename.Length; i++)
            {
                usernamesum += (int)usename[i];
            }

            for (int i = 0; i < host.Length; i++)
            {
                hostsum += host[i];
            }

            if(hostsum-usernamesum>=0)
            {
                Console.WriteLine("Call her!");
            }

            else
            {
                Console.WriteLine("She is not the one.");
            }

           
        }
    }
}
