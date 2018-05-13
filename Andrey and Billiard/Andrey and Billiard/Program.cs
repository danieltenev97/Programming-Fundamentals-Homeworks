using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andrey_and_Billiard
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());


       //  List<SortedDictionary<string, double>> listofproduct = new List<SortedDictionary<string, double>>();    
          SortedDictionary<string, double> productsPrices = new SortedDictionary<string, double>();
        //  SortedDictionary<string, int> qorders = new SortedDictionary<string,int>();
           

            for (int i = 0; i < n; i++)
            {
                var input1 = Console.ReadLine().Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);

                productsPrices[input1[0]] = double.Parse(input1[1]);

         
               }

            var orders1 = new List<Customer>();

            string input = Console.ReadLine();

           while(input!="end of clients")
            {
                string[] newinput = input.Split('-', ',', ' ');
                string producttype = newinput[1];
                string pname = newinput[0];
                int quantity1 = int.Parse(newinput[2]);

                

              var  customer = new Customer(pname,new SortedDictionary<string, int>());
                
                if (!customer.quantity.ContainsKey(producttype))
                {
                    customer.quantity.Add(producttype, quantity1);
                    

                }
                else
                {
                    customer.quantity[producttype] = quantity1 + customer.quantity[producttype];
                
                }







                    if (productsPrices.ContainsKey(producttype))
                {
                    customer.bill = productsPrices[producttype]*customer.quantity[producttype];
                    orders1.Add(customer);
                }

                input = Console.ReadLine();
            }

            double totalBill = 0;

            orders1 = orders1.OrderBy(x => x.name).ToList();
            
              foreach (var customer in orders1)
            {
                Console.WriteLine(customer.name);
                foreach (var item in customer.quantity)
                {
                    Console.WriteLine($"-- {item.Key} - {item.Value}");
                }

                Console.WriteLine($"Bill: {customer.bill:F2}");

                totalBill = totalBill + customer.bill;
            }


            Console.WriteLine($"Total bill: {totalBill:F2}");

        }
    }
}
