using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainAir
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<int>> customers = new Dictionary<string, List<int>>();

            string splitter = "=";

            while(true)
            {
                var input = Console.ReadLine();
                if (input == "I believe I can fly!") break;

                var customersinput = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string name = customersinput[0];

                if(customersinput[1]==splitter)
                {
                    var secondsutomer = customersinput[2];
                    customers[name] = customers[secondsutomer];
                }
                else
                {
                  if(!customers.ContainsKey(name))
                    {
                        customers.Add(name, new List<int>());
                        for (int i = 1; i <customersinput.Length ; i++)
                        {
                            int flight = int.Parse(customersinput[i]);

                            customers[name].Add(flight);
                        }
                    }
                  else
                    {
                        for (int i = 1; i < customersinput.Length; i++)
                        {
                            int flight = int.Parse(customersinput[i]);

                            if (!customers[name].Contains(flight))
                            {
                                customers[name].Add(flight);
                            }
                        }
                    }

                }

            }


            foreach (var item in customers.OrderByDescending(a=>a.Value.Count).ThenBy(a=>a.Key))
            {
                var name = item.Key;
                var value = item.Value.OrderBy(a=>a);

            Console.WriteLine($"#{name} ::: {string.Join(", ",value)} ");
                

            }



        }
    }
}
