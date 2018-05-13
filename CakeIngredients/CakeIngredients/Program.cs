using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "";
            int counter = 0;
            while(true)
            {
             text = Console.ReadLine();
                if (text.Equals("Bake!")) break;
                Console.WriteLine($"Adding ingredient {text}.");
                counter++;
            }

            Console.WriteLine($"Preparing cake with {counter} ingredients.");

        }
    }
}
