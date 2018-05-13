using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drinks
{
    class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            string type = "";
            int quantity = int.Parse(Console.ReadLine());

            double sum = 0;

            if(drink.Equals("Athlete"))
            {
                type = "Water";
                sum = quantity * 0.70;
            }
            else if(drink.Equals("Businessman")||drink.Equals("Businesswoman"))
            {
                type = "Coffee";
                sum = quantity;
            }
            else if(drink.Equals("SoftUni Student"))
            {
                type = "Beer";
                sum = quantity * 1.70;

            }
            else
            {
                type = "Tea";
                sum = quantity * 1.20;
            }

            Console.WriteLine($"The {drink} has to pay {sum:F2}.");
        }
    }
}
