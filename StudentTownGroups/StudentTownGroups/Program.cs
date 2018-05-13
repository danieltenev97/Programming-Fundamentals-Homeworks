using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;

namespace StudentTownGroups
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, List<Group>> students = new SortedDictionary<string, List<Group>>();
            Dictionary<string, decimal> towngroups = new Dictionary<string, decimal>();

            string pattern = @"[\s]*[|]{1,1}[\s]*";
            string town = "";
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End") { break; }
                var currentstudent = new Group();
                var commands = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                if (commands.Contains("=>"))
                {
                    var array = commands.Take(commands.Length - 3).ToArray();
                    // Console.WriteLine(string.Join(" ", array));
                    town = string.Join(" ", array);
                    int groupssize = int.Parse(commands[commands.Length - 2]);

                    students[town] = new List<Group>();
                    towngroups[town] = groupssize;

                }

                else if (input.Contains("|"))
                {
                    var stuDents = Regex.Split(input, pattern);
                    // Console.WriteLine(students[1]);
                    string name = stuDents[0];
                    string email = stuDents[1];
                    DateTime dateregistered = DateTime
                        .ParseExact(stuDents[2], "d-MMM-yyyy", CultureInfo.InvariantCulture);
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
                    if (item.Key == item1.Key)
                    {
                        decimal size = item1.Value;
                        decimal a = item.Value.Count;
                        numbergroups = numbergroups + Math.Ceiling(a / size);
                    }

                }

            }

            Console.WriteLine($"Created {numbergroups} groups in {students.Count} towns:");

            foreach (var emails in students)
            {
                var currenttown = emails.Key;
                int size = (int)towngroups[currenttown];
                var value = emails.Value.OrderBy(x => x.dateregistered).ThenBy(x => x.studentname)
                    .ThenBy(x => x.email);
                int skip = 0;
                int lenght = value.Count();

                while(lenght>0)
                {
                    List<Group> take = new List<Group>();
                    List<string> studentemails = new List<string>();
                    if(lenght>=size)
                    {
                        take = value.Skip(skip).Take(size).ToList();
                    }
                    else
                    {
                        take = value.Skip(skip).Take(lenght).ToList();
                    }
                    foreach (var item in take)
                    {
                        studentemails.Add(item.email);
                    }
                    Console.WriteLine($"{currenttown} => {string.Join(", ",studentemails)}");
                    skip =skip+size;
                    lenght = lenght - size;
                }

            
            }


        }
    }
}
