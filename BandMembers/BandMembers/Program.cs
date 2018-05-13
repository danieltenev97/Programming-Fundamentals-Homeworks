using System;

namespace BandMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            int members = int.Parse(Console.ReadLine());
            double guitarPrice = double.Parse(Console.ReadLine());

            int vocalist = 1;
            double gitars = Math.Floor((double)members / 3);

            double drums = members - gitars - vocalist;


            double drumPrice = guitarPrice + guitarPrice * 0.50;

            double totalGuitarsPrice = gitars * guitarPrice;
            double totaldrumsPrice = drums * drumPrice;

            double microphonePrice = totaldrumsPrice - totalGuitarsPrice;

            double totalExpense = totalGuitarsPrice + totaldrumsPrice + microphonePrice;
            double rentPrice = (totalGuitarsPrice + totaldrumsPrice + microphonePrice) / members;

            rentPrice = rentPrice * 12;
            totalExpense = totalExpense + rentPrice;

            Console.WriteLine($"Total cost: {totalExpense:f2}lv.");
        }
    }
}
