using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem8RegexExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"<p>(.+?)<\/p>";
            Regex regex = new Regex(pattern);
            MatchCollection textmatch = regex.Matches(text);
            string replacepattern = @"[^a-z0-9]+";
            //   string patterntag = @"(<p>|<\/p>)";



            // string takentext = string.Join("", textmatch);
            // takentext = Regex.Replace(takentext, patterntag, "");

            string takentext = string.Empty;

            foreach (Match item in textmatch)
            {
                takentext += item.Groups[1].Value;   // Groups[1]==(.+?) ot patterna

            }

            takentext = Regex.Replace(takentext, replacepattern, " ");

            StringBuilder mystring = new StringBuilder();

            for (int i = 0; i < takentext.Length; i++)
            {
                char letter = takentext[i];
                int letterposition = (int)letter;

               

                if (letterposition < 110&&letterposition>=97)
                {
                    letterposition = letterposition + 13;
                }

                else if(letterposition>109&&letterposition<=122)
                {
                    letterposition = letterposition - 13;
                }
                        

                letter= (char)letterposition;

                mystring.Append(letter);

               
               
           }


            Console.WriteLine(mystring);
           
            
        }
    }
}
