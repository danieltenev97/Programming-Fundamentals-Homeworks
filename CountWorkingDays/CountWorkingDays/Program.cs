using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountWorkingDaysWithDateandTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            List<DateTime> holidays = new List<DateTime>();

            holidays.Add(new DateTime(4, 01, 01));
            holidays.Add(new DateTime(4, 03, 03));
            holidays.Add(new DateTime(4, 05, 01));
            holidays.Add(new DateTime(4, 05, 06));
            holidays.Add(new DateTime(4, 05, 24));
            holidays.Add(new DateTime(4, 09, 06));
            holidays.Add(new DateTime(4, 09, 22));
            holidays.Add(new DateTime(4, 11, 01));
            holidays.Add(new DateTime(4, 12, 24));
            holidays.Add(new DateTime(4, 12, 25));
            holidays.Add(new DateTime(4, 12, 26));
             

            int workingDays = 0;
            for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
            {
                DayOfWeek day = i.DayOfWeek;

                DateTime holiday = new DateTime(4, i.Month, i.Day);

                if (!holidays.Contains(holiday) && (!day.Equals(DayOfWeek.Saturday) && !day.Equals(DayOfWeek.Sunday)))
                {
                    workingDays++;
                }
            }

            Console.WriteLine(workingDays);


        }
    }
}
