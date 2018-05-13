using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;



namespace Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
         

          var input = Console.ReadLine().Split(new[] { " " , "\t" },StringSplitOptions.RemoveEmptyEntries).ToList();
           
            var alphabet = new Dictionary<char, int>();
            decimal sum = 0;
            int position = 1;

            for (char i = 'a'; i <='z'; i++)
            {
                alphabet.Add(i, position);

                position++;
            }

            for (int i = 0; i <input.Count ; i++)
            {
                string element = input[i];
                decimal number = int.Parse(element.Substring(1, element.Length - 2));
                bool isLower = false;
                bool isLower1 = false;
                if(element.Substring(0,1).ToLower().Equals(element.Substring(0, 1)))
                {
                    isLower = true;
                }
                if (element.Substring(element.Length-1, 1).ToLower().Equals(element.Substring(element.Length-1, 1)))
                {
                    isLower1 = true;
                }

                string c = element.Substring(0,1).ToLower();

                string d = element.Substring(element.Length-1, 1).ToLower();
                char firstletter =c[0];
                char lastletter = d[0];
                int firstletterposition=1;
                int lastletterposition=1;

                 if (alphabet.ContainsKey(firstletter))
                {
                     firstletterposition = alphabet[firstletter];
                }
                if (alphabet.ContainsKey(lastletter))
                {
                    lastletterposition = alphabet[lastletter];
                }
                


                decimal currentsum = 0;

                if(isLower==true)
                {
                    currentsum = number * firstletterposition;
                }
                else
                {
                    currentsum = number / firstletterposition;
                }

                if (isLower1 == true)
                {
                    currentsum = currentsum + lastletterposition;
                }
                else
                {
                    currentsum = currentsum - lastletterposition;
                }

                sum = sum + currentsum;
            }

            Console.WriteLine($"{sum:F2}");

            
        }
    }
}
