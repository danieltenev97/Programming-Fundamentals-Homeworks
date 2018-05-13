using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //  SortedDictionary<string, List<double>> average = new SortedDictionary<string, List<double>>();
            List<Student> studens = new List<Student>();
               for (int i = 0; i < n; i++)
            {
                List<double> list = new List<double>();

                var info = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                for (int j = 1; j < info.Count; j++)
                {
                    list.Add(double.Parse(info[j]));
                }
                double averagegrade1 = list.Average();

                var fstudent = new Student()
                {
                    name = info[0],
                    grades=list,
                    averagegrade=averagegrade1
                    
                };

                studens.Add(fstudent); 
              //  Console.WriteLine(string.Join(" ",fstudent.grades));

              /*  if(fstudent.averagegrade>=5)
                {
                    if(!average.ContainsKey(fstudent.name))
                    {
                        average.Add(fstudent.name, new List<double>());
                        average[fstudent.name].Add(fstudent.averagegrade);
                    }

                    average[fstudent.name].Add(fstudent.averagegrade);
                } */
                
               }

            /* foreach (var item in average)
             {
                 var value = item.Value;
                 value.Sort();
                 value.Reverse();

                 if(value.Count==1)
                 {
                     Console.WriteLine($"{item.Key} -> {value[0]:F2}");
                 }

                 else
                 {

                         for (int i = 0; i < value.Count-1; i++)
                         {
                             Console.WriteLine($"{item.Key} -> {value[i]:F2}");
                         }


                 } 

            
               
               


            } */

            foreach (var item in studens.Where(x=>x.averagegrade>=5).OrderBy(x=>x.name).ThenByDescending(y=>y.averagegrade))
            {
                
                Console.WriteLine($"{item.name} -> {item.averagegrade:F2}");
            }
           

            
        }


      
    }
}
