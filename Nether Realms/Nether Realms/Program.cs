using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, double> demonhealth = new SortedDictionary<string, double>();
            SortedDictionary<string, double> demondamage = new SortedDictionary<string, double>();

         var input = Console.ReadLine().Split(new[] { " ", "\t", "," }, StringSplitOptions.RemoveEmptyEntries);


            var regexHealth = @"[^0-9/.+-\/*]+";

            MatchCollection matches = Regex.Matches(input[0], regexHealth);

            foreach (Match item in matches)
            {
                Console.Write(item);
            
            }
            Console.WriteLine();
        }
    }
}
