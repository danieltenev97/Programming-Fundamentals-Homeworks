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

         var input = Console.ReadLine()
                .Split(new[] { " ", "\t", "," }, StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;
          var sum1 = 0.0;
            var regexdamage = @"-?\d+?\.?\d*";
            var regex = new Regex(regexdamage);

            foreach (var demon in input)
            {
                
                sum = 0;
                sum1 = 0;
                for (int j = 0;  j <demon.Length;  j++)
                {
                    char a = demon[j];
                    if(!char.IsDigit(a)&&(a!='+')&&(a!='-') && (a != '*') && (a != '/') && (a != '.'))
                    {
                        sum = sum + (int)a;
                    }

                }

                if (!demonhealth.ContainsKey(demon))
                {
                    demonhealth[demon] = sum;
                }

                MatchCollection mathes = regex.Matches(demon);
                foreach (Match match in mathes)
                {
                    var value = match.Value;
                    sum1 = sum1 + double.Parse(value);
                }

                foreach (var item in demon)
                {
                    if (item == '*')
                    {
                        sum1 = sum1 * 2;

                    }

                    else if (item == '/')
                    {
                        sum1 = sum1 / 2;

                    }

                 
                

            }

                demondamage[demon] = sum1;

           

           }

            foreach (var item in demondamage)
            {
                var key = item.Key;
                Console.WriteLine($"{key} - {demonhealth[key]} health, {item.Value:F2} damage");
            }
              



        }
    }
}
