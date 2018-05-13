using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaruant
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupsize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            string hall = "";
            double price = 0;

            if(groupsize<=50)
            {
                hall = "Small Hall";
                price = 2500;
            }
            else if(groupsize>50&&groupsize<=100)
            {
                hall = "Terrace";
                price = 5000;
            }
            else if(groupsize>120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            else
            {
                hall = "Great Hall";
                price = 7500;
            }

            if(package.Equals("Normal"))
            {
                price = (price + 500) * 0.95;
            }

            else if(package.Equals("Gold"))
            {
                price = (price + 750) * 0.90;
            }
            else if (package.Equals("Platinum"))
            {
                price = (price + 1000) * 0.85;
            }
            price = price / groupsize;
            Console.WriteLine($"We can offer you the {hall}");
            Console.WriteLine($"The price per person is {price:F2}$");

        }
    }
}
