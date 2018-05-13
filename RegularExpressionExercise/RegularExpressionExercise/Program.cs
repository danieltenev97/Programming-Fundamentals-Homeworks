using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressionExercise
{
    class Program
    {
        static void Main(string[] args)
        {
                        string text = Console.ReadLine();

                        string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";
                        Regex regex = new Regex(pattern);


                      MatchCollection matches = Regex.Matches(text,pattern);

                        foreach (Match item in matches)
                        {

                            Console.Write(item.Value + " ");
                        }
                        
           
        }
    }
}
