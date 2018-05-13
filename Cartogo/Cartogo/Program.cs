using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartogo
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string class1="";
            string cartype = "";
            double carprice = 0;

            if (season.Equals("Summer"))
            {
                if (budget <= 100)
                {
                    class1 = "Economy class";
                    cartype = "Cabrio";
                    carprice = budget * 0.35;
                }
                else if (budget > 100 && budget <= 500)
                {
                    class1 = "Compact class";
                    cartype = "Cabrio";
                    carprice = budget * 0.45;
                }

                else
                {
                    class1 = "Luxury class";
                    cartype = "Jeep";
                    carprice = budget * 0.90;
                }
            }

            else if(season.Equals("Winter"))
            {
                if (budget <= 100)
                {
                    class1 = "Economy class";
                    cartype = "Jeep";
                    carprice = budget * 0.65;
                }
                else if (budget > 100 && budget <= 500)
                {
                    class1 = "Compact class";
                    cartype = "Jeep";
                    carprice = budget * 0.80;
                }

                else
                {
                    class1 = "Luxury class";
                    cartype = "Jeep";
                    carprice = budget * 0.90;
                }

            }

            Console.WriteLine($"{class1}");
            Console.WriteLine($"{cartype} - {carprice:F2}");

            }
        }
            }

        