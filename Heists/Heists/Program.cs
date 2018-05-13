using System;
using System.Collections.Generic;
using System.Linq;


namespace Heists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] prices = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int jeweryprice = prices[0];
            int goldprice = prices[1];

            if (prices.Length>2)
            {
                return;
            }
            decimal earnings = 0;
            decimal expenses = 0;
            string input = Console.ReadLine();

            while(!input.Equals("Jail Time"))
            {
                string[] newinput = input.Split(' ').ToArray();

                string earn = newinput[0];
               char pricejewery = '%';
               char pricegold = '$';
                int expense = int.Parse(newinput[1]);
                for (int i = 0; i <earn.Length; i++)
                {
                    if(earn[i]==pricegold)
                    {
                        earnings = earnings+goldprice;
                    }
                    else if(earn[i] ==pricejewery)
                    {
                        earnings = earnings + jeweryprice;
                    }
                }

                expenses = expenses + expense;


                input = Console.ReadLine();
            }

            if(earnings>=expenses)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {earnings-expenses}.");
            }
            else
            {
                decimal lost = expenses - earnings;
                Console.WriteLine($"Have to find another job. Lost: {lost}. ");
            }
                    
        }

       
           
        
    }
}
