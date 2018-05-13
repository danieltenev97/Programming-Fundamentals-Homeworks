using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolcamp
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeofholiday = Console.ReadLine();
            string typeofgroup = Console.ReadLine();
            int numberofstudents = int.Parse(Console.ReadLine());
            int numberofnights = int.Parse(Console.ReadLine());
            string sports = "";
            double studentsprice = 0;
            if (typeofholiday.Equals("Winter"))
            {
               
                if(typeofgroup.Equals("boys"))
                {
                    sports = "Judo";
                    studentsprice = (numberofstudents * 9.60) * numberofnights;

                }
                else if(typeofgroup.Equals("girls"))
                {
                    sports = "Gymnastics";
                    studentsprice = (numberofstudents * 9.60) * numberofnights;

                }
                else
                {
                    sports = "Ski";
                    studentsprice = (numberofstudents * 10) * numberofnights;

                }
            }

            else if(typeofholiday.Equals("Spring"))
            {
                if (typeofgroup.Equals("boys"))
                {
                    sports = "Tennis";
                    studentsprice = (numberofstudents * 7.20) * numberofnights;

                }
                else if (typeofgroup.Equals("girls"))
                {
                    sports = "Athletics";
                    studentsprice = (numberofstudents * 7.20) * numberofnights;

                }
                else
                {
                    sports = "Cycling";
                    studentsprice = (numberofstudents * 9.50) * numberofnights;

                }
            }

            else
            {
                if (typeofgroup.Equals("boys"))
                {
                    sports = "Football";
                    studentsprice = (numberofstudents * 15) * numberofnights;

                }
                else if (typeofgroup.Equals("girls"))
                {
                    sports = "Voleyball";
                    studentsprice = (numberofstudents * 15) * numberofnights;

                }
                else
                {
                    sports = "Swimming";
                    studentsprice = (numberofstudents * 20) * numberofnights;

                }
            }


            if(numberofstudents>=50)
            {
                studentsprice = studentsprice * 0.50;
            }

            if(numberofstudents>=20&&numberofstudents<50)
            {
                studentsprice = studentsprice * 0.85;
            }

            if(numberofstudents >= 10 && numberofstudents < 20)
            {
                studentsprice = studentsprice * 0.95;
            }

            Console.WriteLine($"{sports} {studentsprice:F2} lv.");
        }
    }
}
