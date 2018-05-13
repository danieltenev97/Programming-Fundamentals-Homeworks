using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holiday
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double holidayprice = 0;

            string stay = "";
            string place = "";
            if(budget<=1000)
            {
                place = "Camp";
                if(season.Equals("Summer"))
                {
                    stay = "Alaska";
                    holidayprice = budget * 0.65;
                }
                else
                {
                    stay = "Morocco";
                    holidayprice = budget * 0.45;
                }
            }
            else if(budget>1000&&budget<=3000)
            {
                place = "Hut";
                if (season.Equals("Summer"))
                {
                    stay = "Alaska";
                    holidayprice = budget * 0.80;
                }
                else
                {
                    stay = "Morocco";
                    holidayprice = budget * 0.60;
                }
            }
            else
            {
                place = "Hotel";
                if (season.Equals("Summer"))
                {
                    stay = "Alaska";
                    holidayprice = budget * 0.90;
                }
                else
                {
                    stay = "Morocco";
                    holidayprice = budget * 0.90;
                }
            }

            Console.WriteLine($"{stay} - {place} - {holidayprice:F2} ");

        }
    }
}
