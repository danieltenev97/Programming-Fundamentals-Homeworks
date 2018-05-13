using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gifts
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            int money = int.Parse(Console.ReadLine());
            string syvenir = "";
            double price = 0;

            for (int i = 1; i <=number; i++)
            {
                syvenir = Console.ReadLine();
                if(syvenir.Equals("sand clock"))
                {
                    price = price + 2.20;
                }
                else if(syvenir.Equals("magnet"))
                {
                    price = price + 1.50;
                }
                else if (syvenir.Equals("cup"))
                {
                    price = price + 5;

                }
                else if (syvenir.Equals("t-shirt"))
                {
                    price = price + 10;
                }

            }

            if(price<=money)
            {
                double leftmoney = money - price;
                Console.WriteLine($"Santa Claus has {leftmoney:F2} more leva left!");
            }
            else
            {
                double needmoney = price - money;
                Console.WriteLine($"Santa Claus will need {needmoney:F2} more leva.");
            }
        }
    }
}
