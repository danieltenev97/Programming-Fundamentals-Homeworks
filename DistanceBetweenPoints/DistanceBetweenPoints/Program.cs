using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceBetweenPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PointCordinates[] points = new PointCordinates[n];

            for (int i = 0; i <n; i++)
            {
                points[i] = Createpoint();
            }

         
            double distance = 0;
            double mindistance=double.MaxValue;
            int m = points.Length;
            int x = 0; int x1 = 0;
            int y = 0; int y1 = 0;

            for (int i = 0; i < m; i++)
            {

                for (int j = i+1; j <m ; j++)
                {
                    int xx1 = Math.Max(points[j].x, points[i].x) - Math.Min(points[j].x, points[i].x);
                    int yy1 = Math.Max(points[j].y, points[i].y) - Math.Min(points[j].y, points[i].y);

                   
                    distance = Math.Sqrt(xx1 * xx1 + yy1 * yy1);

                    if(distance<mindistance)
                    {
                        mindistance = distance;
                        x = points[i].x;
                        y = points[i].y;
                        x1 = points[j].x;
                        y1 = points[j].y;
                    }
                }

               
            }


         
            

           Console.WriteLine($"{mindistance:F3}");
           Console.WriteLine($"({x}, {y})");
           Console.WriteLine($"({x1}, {y1})");
        }

        public static PointCordinates Createpoint()
        {
            string[] read = Console.ReadLine().Split(' ');

            return new PointCordinates()
            {

                x = int.Parse(read[0]),
                y = int.Parse(read[1])
            };
        }
    }
}
