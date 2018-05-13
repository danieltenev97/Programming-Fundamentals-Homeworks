using System;
using System.Collections.Generic;
using System.Linq;

namespace Icarus
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();



            int damage = 1;

            int index = int.Parse(Console.ReadLine());
           
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Supernova") { break; }

                var commands = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                string direction = commands[0];
                int steps = int.Parse(commands[1]);

                if (direction == "right")
                {
                    int i = 1;

                    while (i <= steps)
                    {
                        index++;
                     
                        if (index > numbers.Count - 1)
                        {
                            index = 0;
                            damage++;
                        }
                        numbers[index] = numbers[index] - damage;

                        i++;
                    }
                }

                else if(direction=="left")
                {
                    int i = 1;

                    while (i <= steps)
                    {
                        index--;
                        if (index < 0)
                        {
                            index = numbers.Count - 1;
                            damage++;
                        }
                     
                        numbers[index] = numbers[index] - damage;
                        i++;
                    }
                }

            }

            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
