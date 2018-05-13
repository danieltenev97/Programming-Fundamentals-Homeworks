using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeighbourWars
{
    class Program
    {
        static void Main()
        {
            int Peshodamage = int.Parse(Console.ReadLine());
            int Goshodamage = int.Parse(Console.ReadLine());

            int peshohealth = 100;
            int goshohealth = 100;
            int a = 1;
            


            while(true)
            {
               
                if (a % 2 != 0)
                {
                    goshohealth = goshohealth - Peshodamage;
                    if (goshohealth <= 0) break;
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshohealth} health.");
                 
                }
                else
                {
                    peshohealth = peshohealth - Goshodamage;
                    if (peshohealth <= 0) break;
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshohealth} health.");

                }
                if (a % 3 == 0)
                {
                    goshohealth = goshohealth + 10;
                    peshohealth = peshohealth + 10;
                }
                a++;

            }

            if (goshohealth > 0)
            {
                Console.WriteLine($"Gosho won in {a}th round.");
            }
            else
            {
                Console.WriteLine($"Pesho won in {a}th round.");
            }
        }
    }
}
