using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp64
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double studioprice = 0;
            double doublestudioprice = 0;
            double suiteprice = 0;
            if (days > 200) return;

            if(month.Equals("May")||month.Equals("October"))
            {
                studioprice = days * 50;
                doublestudioprice = days * 65;
                suiteprice = days * 75;
                if (days > 7)
                {
                    studioprice = studioprice * 0.95;
                }
            }

            else if (month.Equals("June") || month.Equals("September"))
            {
                studioprice = days*60;
                doublestudioprice =days* 72;
                suiteprice = days*82;
                if (days > 14)
                {
                    doublestudioprice = doublestudioprice * 0.90;
                }


            }
            else if (month.Equals("July") || month.Equals("August")|| month.Equals("December"))
            {
                studioprice = days * 68;
                doublestudioprice = days * 77;
                suiteprice = days * 89;
                if (days > 14)
                {
                    suiteprice = suiteprice * 0.85;
                }
            }

            else
            {
                return;
            }

           

            if(month.Equals("September")||month.Equals("October"))
            {
                if(days>7)
                studioprice = studioprice - studioprice / days;
            }

            Console.WriteLine($"Studio: {studioprice:F2} lv.");
            Console.WriteLine($"Double: {doublestudioprice:F2} lv.");
            Console.WriteLine($"Suite: {suiteprice:F2} lv.");

        }
    }
}
