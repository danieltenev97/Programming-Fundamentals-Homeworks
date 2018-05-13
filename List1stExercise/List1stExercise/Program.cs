using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List1stExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List < int > numbers= Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            double a = 0;
            numbers.Sort();
            numbers.Reverse();
            foreach (var n in numbers)
            {
                a = Math.Sqrt(n);
                if (a ==(int)a)
                {
                    Console.Write(n +" ");
                }
            }
            Console.WriteLine();


        }
    }
}
