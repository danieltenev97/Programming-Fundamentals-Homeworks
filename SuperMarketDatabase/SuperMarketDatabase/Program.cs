using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace SuperMarketDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> productprice = new Dictionary<string, double>();
            Dictionary<string, int> productquantity = new Dictionary<string, int>();

            while(true)
            {
                string input = Console.ReadLine();
                if(input== "stocked") { break; }

                var commands = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                string productname = commands[0];
                double productPrice = double.Parse(commands[1]);
                int productQuantity = int.Parse(commands[2]);

                if(!productprice.ContainsKey(productname))
                {
                    productprice[productname] = productPrice;
                    productquantity[productname] = productQuantity;
                }
                else
                {
                    productprice[productname] = productPrice;
                    productquantity[productname] = productquantity[productname] + productQuantity;
                }

            }

            double totalPrice = 0;

            foreach (var item in productprice)
            {
                var product = item.Key;
                var price = item.Value;
                var totalproductPrice = price * productquantity[product];

                Console.WriteLine($"{product}: ${price:F2} * {productquantity[product]} = ${totalproductPrice:F2}");
                totalPrice = totalPrice + totalproductPrice;
            }

            Console.WriteLine(new string('-',30));
            Console.WriteLine($"Grand Total: ${totalPrice:F2}");

        }
    }
}
