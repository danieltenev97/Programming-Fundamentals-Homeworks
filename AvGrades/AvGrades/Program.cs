using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace AvGrades
{
    class Program
    {
        static void Main(string[] args)
        {
           int n=int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                var currentstudent = new Student();
                var input = Console.ReadLine().Split(' ');
                string name = input[0];
                List<double> grades = new List<double>();
                for (int j = 1; j <input.Length; j++)
                {
                    double mark = double.Parse(input[j]);
                  
                  grades.Add(mark);
                    
                }

                double average = grades.Average();
                currentstudent = CreateStudent(name, grades, average);

                if(currentstudent.average>=5)
                students.Add(currentstudent);
               
            }

            foreach (var item in students.OrderBy(a=>a.name).ThenByDescending(a=>a.average))
            {
                var name = item.name;
                var gradeaverage = item.average;

                Console.WriteLine($"{name} -> {gradeaverage:f2}");

            }

        }

        static Student CreateStudent(string name, List<double> grades, double average)
        {
            var current = new Student();

              current.name = name;
            current.grades = grades;
            current.average = average;

            return current;

                
        }
    }
}
