using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesReport
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Sales> towns = new List<Sales>();

            for (int i = 0; i < n; i++)
            {
                towns.Add(CreateSales());
            }
            double totalprice = 0;
         //   double result = 0;
            SortedDictionary<string, double> salesdictionay = new SortedDictionary<string, double>();

            for (int i = 0; i < towns.Count; i++)
            {
                string city = towns[i].town;
                totalprice = towns[i].price * towns[i].quantity;

                if (salesdictionay.ContainsKey(city))
                {
                   salesdictionay[city] = totalprice+salesdictionay[city];
                }
                else
                {
                    salesdictionay[city] = totalprice;
                }

               

             }

            foreach (var item in salesdictionay)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:F2}");
            }



        }


        public static Sales CreateSales()
        {
            string[] info = Console.ReadLine().Split(' ');

            return new Sales()
            {
                town = info[0],
                product = info[1],
                price = double.Parse(info[2]),
                quantity=double.Parse(info[3])
            };


            

        }
    }
}
