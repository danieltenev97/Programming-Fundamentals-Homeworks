using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {

            int days = int.Parse(Console.ReadLine());
            int participants = int.Parse(Console.ReadLine());
            double avgnumberoflaps = double.Parse(Console.ReadLine());
            double lengthofthetrack = double.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            double moneydonated = double.Parse(Console.ReadLine());

           
            int totalcapacity = days * capacity;
            if(participants>=totalcapacity)
            {
                participants = totalcapacity;
            }

            double distance = avgnumberoflaps * lengthofthetrack;

           double totalruninKm = (participants * distance) / 1000;

            double donatedmoney = totalruninKm * moneydonated;

            Console.WriteLine($"Money raised: {donatedmoney:F2}");

        }
    }
}
