using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photos
{
    class Photos

    {
        static void Main(string[] args)
        {
            int numberpictures = int.Parse(Console.ReadLine());
            int filtertimefor1picture = int.Parse(Console.ReadLine());
            int filterfactor = int.Parse(Console.ReadLine());
            int uploadtimefor1picture = int.Parse(Console.ReadLine());

            if (filterfactor < 0 || filterfactor > 100) return;

            double picturestobefiltered = Math.Ceiling((double)(numberpictures * filterfactor) / 100);

            double timeforpicturestobefiltered = picturestobefiltered * filtertimefor1picture;

            int timeforupload =(int)(numberpictures-picturestobefiltered)*filtertimefor1picture;

            int totaltime = (int)(timeforpicturestobefiltered + timeforupload);

            double minutes = Math.Floor((double)totaltime /60);
            double hours = Math.Floor((double)totaltime/3600);
            double seconds = Math.Floor((double)totaltime % 60);
            int days =(int)hours/24;
           

            

            Console.WriteLine(minutes);

            Console.WriteLine($"{days:D2}:{hours:D2}:{minutes:D2}:{seconds:D2}");







        }
    }
}
