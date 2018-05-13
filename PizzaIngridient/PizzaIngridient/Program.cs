using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaIngridient
{
    class Program
    {
        static void Main(string[] args)
        {
            var ingredient = Console.ReadLine().Split(' ').ToArray();
            string[] useding = new string[10];

            int lenght = int.Parse(Console.ReadLine());
            int counter = 0;
            int index = 0;


            for (int i = 0; i < ingredient.Length; i++)
            {
                if(index>9)
                {
                    break;
                }
                if(counter>10)
                {
                    break;
                }
                int ingredientlength = ingredient[i].Length;

                if(lenght==ingredientlength)
                {
                    counter++;
                    useding[index] = ingredient[i];

                    Console.WriteLine($"Adding {ingredient[i]}.");
                    index++;
                }

            }

            Console.WriteLine($"Made pizza with total of {counter} ingredients.");
            Console.WriteLine("The ingredients are: "+ string.Join(", ",useding.Where(a=>a!=null))+".");

        }
    }
}
