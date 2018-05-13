using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace MentrorGroup
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Mentors> mentors = new List<Mentors>();

            while(true)
            {
                string input = Console.ReadLine();
                if(input== "end of dates") { break; }
                bool contains = false;
                var commands = input.Split(new[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries);
                string name = commands[0];
                List<DateTime> dates = new List<DateTime>();
                for (int i = 1; i < commands.Length; i++)
                {
                    DateTime date = DateTime.ParseExact(commands[i], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    dates.Add(date);
                }
              

                var currentmentor = new Mentors();

                foreach (var item in mentors)
                {
                    if(name==item.name)
                    {
                        item.date.AddRange(dates);
                        contains = true;
                    }
                }

                if(contains!=true)
                {
                    currentmentor.name = name;
                    currentmentor.date = dates;
                    mentors.Add(currentmentor);
                }

                
            }
            while(true)
            {
                string input = Console.ReadLine();
                if(input== "end of comments") { break; }
                var commands = input.Split(new[] { "-"}, StringSplitOptions.RemoveEmptyEntries);
                string name = commands[0];
               
                List<string> comments = new List<string>();

               
                for (int i = 1; i < commands.Length; i++)
               {
                    comments.Add(commands[i]);
               }


                foreach (var item in mentors)
                {
                    if(name==item.name)
                    {
                        item.comments.AddRange(comments);
                    }
                }


            }

            foreach (var item in mentors.OrderBy(a=>a.name))
            {
                Console.WriteLine(item.name);
                Console.WriteLine("Comments:");
                if(item.comments.Count!=0)
               {
                    var comments = item.comments;

                    foreach (var item1 in comments)
                    {
                        Console.WriteLine($"- {item1}");
                    }
                }
                Console.WriteLine("Dates attended:");
                if (item.date.Count != 0)
               {
                    var dates = item.date;

                    foreach (var item1 in dates.OrderBy(a=>a))
                    {
                        Console.WriteLine($"-- {item1.ToString("dd/MM/yyyy")}");
                    }
                }


            }
                    


        }
    }
}
