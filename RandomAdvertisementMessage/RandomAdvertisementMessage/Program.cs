using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomAdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] authors = new string[] {
                "Diana", "Petya","Stella", "Elena", "Katya", "Iva", "Annie", "Eva"

            };
            string[] cities = new string[]
            {
                "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
            };

            string[] events = new string[]
            {
                "Now I feel good.", "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied."
                , "I feel great!"
            };

            string[] phrases = new string[]
            {
                "Excellent product.", "Such a great product.", "I always use that product.",
               "Best product of its category.",
                "Exceptional product.", "I can’t live without this product."

            };

            int n = int.Parse(Console.ReadLine());
            var random = new Random();

            

            for (int i = 0; i <n; i++)
            {
                var randomcity = random.Next(0, cities.Length);

                var randomauthor = random.Next(0, authors.Length);

                var randomphrases = random.Next(0, phrases.Length);

                var randomevents = random.Next(0, phrases.Length);

                Console.WriteLine($"{phrases[randomphrases]} {events[randomevents]} {authors[randomauthor]} - {cities[randomcity]}");
                    
                  
              
            }

        }
    }
}
