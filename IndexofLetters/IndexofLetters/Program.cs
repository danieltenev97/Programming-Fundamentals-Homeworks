using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexofLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] letter = new char[26];
            string letter1 = Console.ReadLine().ToLower();

            char firstletter = 'a';
            for (int i = 0;i<=25; i++)
            {
                letter[i] = firstletter;
                firstletter++;
                
            }
            for (int i = 0; i <letter1.Length ; i++)
            {
                for (int j = 0; j < letter.Length; j++)
                {
                    if(letter1[i]==letter[j])
                    {
                        Console.WriteLine($"{letter1[i]} -> {j}");
                    }
                }

            }
           
            Console.WriteLine();
        }
    }
}
