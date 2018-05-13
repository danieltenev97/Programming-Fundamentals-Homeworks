using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageGrades
{
    class Student
    {
        public string name { get; set; }
        public List<double> grades { get; set; } 


        public double averagegrade { get; set; }


        public void Load(double data)
        {
           grades.Add(data);
        }


    }
}
