using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> persondcards = new Dictionary<string, List<string>>();
            Dictionary<string, int> cardsvalue = new Dictionary<string, int>();



            while (true)
            {
                string input = Console.ReadLine();
                if (input == "JOKER") { break; }

                var command = input.Split(new[] { ", ", ": " }, StringSplitOptions.RemoveEmptyEntries);

                string personame = command[0];
                if (!persondcards.ContainsKey(personame))
                {
                    persondcards.Add(personame, new List<string>());
                    for (int i = 1; i < command.Length; i++)
                    {
                        persondcards[personame].Add(command[i]);
                    }

                }
                else
                {


                    for (int i = 1; i < command.Length; i++)
                    {
                        persondcards[personame].Add(command[i]);
                    }



                }
                List<string> distinct = persondcards[personame].Distinct().ToList();
                persondcards[personame] = distinct;


            }

            /*    foreach (var item in persondcards)
                {
                    Console.WriteLine(item.Key);
                    foreach (var item1 in item.Value)
                    {
                        Console.Write(item1 + " ");
                    }
                    Console.WriteLine();
                } */

            foreach (var item in persondcards)
            {
                var key = item.Key;
                var list = item.Value;
                foreach (var item1 in list)
                {
                    if (item1.Length == 2)
                    {
                        char cardvalue = item1[0];
                        char multiply = item1[item1.Length - 1];
                        int card = returncardvalue(cardvalue);
                        int bonus = returnmultuply(multiply);
                        int result = card * bonus;

                        if (!cardsvalue.ContainsKey(key))
                        {
                            cardsvalue[key] = result;
                        }
                        else
                        {
                            cardsvalue[key] += result;
                        }
                    }
                    else
                    {
                        char cardvalue = item1[1];
                        char multiply = item1[item1.Length - 1];
                        int card = returncardvalue(cardvalue);
                        int bonus = returnmultuply(multiply);
                        int result = card * bonus;

                        if (!cardsvalue.ContainsKey(key))
                        {
                            cardsvalue[key] = result;
                        }
                        else
                        {
                            cardsvalue[key] += result;

                        }
                    }

                }
            }
                foreach (var item2 in cardsvalue)
                {
                    Console.WriteLine($"{item2.Key}: {item2.Value}");
                }



            
        }
    

        static int returncardvalue(char card)
        {
            switch(card)
            {
                case '1': return 1;
                case '2': return 2;
                case '3': return 3;
                case '4': return 4;
                case '5': return 5;
                case '6': return 6;
                case '7': return 7;
                case '8': return 8;
                case '9': return 9;
                case 'J': return 11;
                case 'Q': return 12;
                case 'K': return 13;
                case 'A': return 14;
                default:  return 10;

                   
            }
          
        }

        static int returnmultuply(char symb)
        {
            switch(symb)
            {
                case 'C': return 1;
                case 'D': return 2;
                case 'H': return 3;
                case 'S': return 4;
            }

            return 1;
        }
    }
}
