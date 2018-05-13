using System;
using System.Collections.Generic;
using System.Linq;

namespace DrumSet
{
    class Program
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine());

            List<int> numbers = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            List<int> savednumbers = new List<int>();

            savednumbers.AddRange(numbers);

            while(true)
            {
                string input = Console.ReadLine();
                if (input == "Hit it again, Gabsy!") { break; }

                int power = int.Parse(input);
                int newDrumPrice = 0;

                for (int i = 0; i <numbers.Count; i++)
                {
                    numbers[i] = numbers[i] - power;

                    if(numbers[i]<=0)
                    {
                        newDrumPrice = savednumbers[i] * 3;

                        double enoughMoney = savings - newDrumPrice;

                        if(enoughMoney>=0)
                        {
                            numbers[i] = savednumbers[i];
                            savings = savings - newDrumPrice;
                        }
                        else
                        {
                           // numbers[i] = 0;

                         //     numbers.Remove(numbers[i]);
                         //   savednumbers.Remove(savednumbers[i]);
                           numbers[i] = 0;
                           savednumbers[i] = 0;
                        }

                        
                    }
                }

            }

            if(savings<0)
            {
                savings = 0;
            }

            List<int> leftnumbers = new List<int>();

            foreach (var item in numbers)
            {
                if(item>0)
                {
                    leftnumbers.Add(item);
                }
            }

            Console.WriteLine(string.Join(" ",leftnumbers));
            Console.WriteLine($"Gabsy has {savings:f2}lv.");
        }
    }
}
