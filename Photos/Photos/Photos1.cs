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

            long filterpictures =(long) numberpictures * filtertimefor1picture;
            long picturestoupload = (long)Math.Ceiling(numberpictures * (filterfactor/100d));

            long uploadtime = (long)picturestoupload * uploadtimefor1picture;
            long totaltime =(long) filterpictures + uploadtime;


            var timespan = TimeSpan.FromSeconds(totaltime);


           Console.WriteLine(timespan.ToString(@"d\:hh\:mm\:ss"));







        }
    }
}
