using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaHoliday
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string stay = Console.ReadLine();
            string grate = Console.ReadLine();
            double price = 0;
            double totalprice=0;
            int nights = days - 1;

            if (stay.Equals("room for one person"))
            {
                price = 18.00;
                if (nights < 10)
                {
                    totalprice = nights * price;
                }

                else if (nights >= 10 && nights <= 15)
                {
                    totalprice = nights * price;
                }
                else if (nights > 15)
                {
                    totalprice = nights * price;
                }
            }

            else if(stay.Equals("apartment"))
            {
                price = 25.00;
                if (nights < 10)
                {
                    totalprice = (nights * price)*0.70;
                }

                else if (nights >= 10 && nights <= 15)
                {
                    totalprice = (nights * price)*0.65;
                }
                else if (nights > 15)
                {
                    totalprice = (nights * price)*0.50;
                }
            }

            else if (stay.Equals("president apartment"))
            {
                price = 35.00;
                if (nights < 10)
                {
                    totalprice = (nights * price) * 0.90;
                }

                else if (nights >= 10 && nights <= 15)
                {
                    totalprice = (nights * price) * 0.85;
                }
                else if (nights > 15)
                {
                    totalprice = (nights * price) * 0.80;
                }
            }

            if(grate.Equals("positive"))
            {
                totalprice = totalprice + totalprice * 0.25;
            }

            else if(grate.Equals("negative"))
            {
                totalprice = totalprice * 0.90;
            }

            Console.WriteLine($"{totalprice:F2}");





            

        }
    }
}
