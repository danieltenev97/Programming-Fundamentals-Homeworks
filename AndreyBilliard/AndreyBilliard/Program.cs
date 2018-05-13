using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreyBilliard
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            List<Client> clients = new List<Client>();

            Dictionary<string, double> dproducts = new Dictionary<string,double>();

            for (int i = 0; i <n ; i++)
            {
                var products = Console.ReadLine()
                    .Split(new[] { "-"}, StringSplitOptions.RemoveEmptyEntries);
                var name = products[0];
                double price = double.Parse(products[1]);

                dproducts[name] = price;
                


            }


            while(true)
            {
                string input = Console.ReadLine();
                bool contains = false;
                if(input== "end of clients") { break; }

                var clientproduct = input.Split(new[] { "-", "," }, StringSplitOptions.RemoveEmptyEntries);

                string personname = clientproduct[0];
                string product = clientproduct[1];
                int quantity = int.Parse(clientproduct[2]);
                double price = 0;

                if(dproducts.ContainsKey(product))
                {
                    price = dproducts[product] * quantity;
                }
                else
                {
                    continue;
                }

                var person = new Client();
                person.name = personname;
                person.price = price;
                person.productquantity[product] = quantity;

                foreach (var item in clients)
                {
                    var name = item.name;
                   

                    if(name==personname)
                    {
                       
                     item.price = price+item.price;
                        if (!item.productquantity.ContainsKey(product))
                        {
                            item.productquantity[product] = quantity;
                        }
                        else
                        {
                            item.productquantity[product] += quantity;
                        }
                        contains = true;
                    }

                }


             if(contains!=true)
                clients.Add(person);
            }
            double totalprice = 0;

            foreach (Client item in clients.OrderBy(a=>a.name))
            {
                Console.WriteLine(item.name);
                double currentprice = item.price;
                

                foreach (var item1 in item.productquantity)
                {
                    Console.WriteLine($"-- {item1.Key} - {item1.Value}");
                    
                }
                Console.WriteLine($"Bill: {currentprice:f2}");
                totalprice = totalprice + currentprice;
            }

            Console.WriteLine($"Total bill: {totalprice:f2}");
                    
            
        }
    }
}
