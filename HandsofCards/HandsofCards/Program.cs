using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsofCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> cards = new Dictionary<string, List<string>>();

           
            string[] name;
           
            int result = 0;

            string command = Console.ReadLine();
           
              while(!command.Equals("JOKER"))
            {
                name = command.Split(new[] { ": " }, StringSplitOptions.RemoveEmptyEntries);
            

                List<string> cards1 = name[1]
                    .Split(new[] {", "}, StringSplitOptions.RemoveEmptyEntries).ToList();

                string playername = name[0];

                if(!cards.ContainsKey(playername))
                {
                    cards.Add(playername,new List<string>());
                }

                cards[playername].AddRange(cards1);

                command = Console.ReadLine();
                                
               
                
            }
            string key1 = "";
            foreach (var item in cards)
            {

                key1 = item.Key;
                var peopleHands = item.Value.Distinct().ToList();
                result = getvalue(peopleHands);

                Console.WriteLine($"{key1}: {result}");


            }

            
             
        }

        public static int getvalue(List<string> cards1)
        {
            int value = 0;

            for (int i = 0; i < cards1.Count; i++)
            {
                int faceCardpower = getCardValue(cards1[i].Substring(0, cards1[i].Length - 1));
                int suitPower = GetCardPower(cards1[i].Substring(cards1[i].Length - 1));

                value += faceCardpower * suitPower;
            }

            return value;

        }

        public static int getCardValue(string facecard)
        {
            
            switch(facecard)
            {
                case "1": return 1;
                case "2": return 2;
                case "3":
                    return 3;
                case "4": return 4;
                case "5": return 5;
                case "6": return 6;
                case "7": return 7;
                case "8": return 8;
                case "9": return 9;
                case "10": return 10;
                case "J": return 11;
                case "Q": return 12;
                case "K": return 13;
                case "A": return 14;
            }

            return 0;
        }

        public static int GetCardPower(string powerdcard)
        {
            switch (powerdcard)
            {
                case "S": return 4;
                case "D": return 2;
                case "H": return 3;
                case "C": return 1;
            }
            return 0;
        }
    }
}
