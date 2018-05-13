using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;

namespace StudentGroups
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[\s]*[|]{1,1}[\s]*";


            Dictionary<string, List<Group>> students = new Dictionary<string, List<Group>>();
            Dictionary<string, decimal> towngroups = new Dictionary<string, decimal>();

            string town = "";
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End") { break; }
                var currentstudent = new Group();
                var commands = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
              
                if (commands.Contains("=>"))
                {
                    var array= commands.Take(commands.Length - 3).ToArray();
                   // Console.WriteLine(string.Join(" ", array));
                    town = string.Join(" ", array);
                    int groupssize = int.Parse(commands[commands.Length - 2]);

                    students.Add(town, new List<Group>());
                    towngroups[town] = groupssize;
                
                }

                else if(input.Contains("|"))
                {
                    var stuDents = Regex.Split(input, pattern);
                   // Console.WriteLine(students[1]);
                    string name = stuDents[0];
                    string email = stuDents[1];
                    DateTime dateregistered = DateTime
                        .ParseExact(stuDents[2], "dd-MMM-yyyy", CultureInfo.InvariantCulture);
                    currentstudent.studentname = name;
                    currentstudent.dateregistered = dateregistered;
                    currentstudent.email = email;

                    students[town].Add(currentstudent);
                  
                }

             
            }

            decimal numbergroups = 0;
            

            foreach (var item in students)
            {
                foreach (var item1 in towngroups)
                {
                    if(item.Key==item1.Key)
                    {
                        decimal size = item1.Value;
                        decimal a = item.Value.Count;
                        numbergroups = numbergroups + Math.Ceiling(a / size);
                    }
                }
               
            }

            Console.WriteLine(numbergroups);

        }
    }
}
