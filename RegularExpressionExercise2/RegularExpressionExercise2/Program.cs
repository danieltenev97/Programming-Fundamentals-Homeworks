using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegularExpressionExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
              string pattern = @"\+359( |-)[2]{1}\1[2]{3}\1[2]{4}\b";

              var text = Console.ReadLine();
           //   Regex regex = new Regex(pattern);

              MatchCollection matches = Regex.Matches(text, pattern);

              var mathedphones = matches.Cast<Match>().Select(a => a.Value.Trim()).ToArray();

              Console.WriteLine(string.Join(", ",mathedphones)); 

           

        }
    }
}
