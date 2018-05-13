using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intersection_of_Circles
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstcircle = Create();

            var secondcircle = Create();

            

            bool result = Intersect(firstcircle, secondcircle);

            if(result==true)
            {
                Console.WriteLine("Yes");
            }

            else
            {
                Console.WriteLine("No");
            }

           
        }

       static bool Intersect(Circle c1, Circle c2)
        {

            double x = c1.x; double x1 = c2.x;
            double y = c1.y; double y1 = c2.y;

            double xx1 = Math.Max(x, x1) - Math.Min(x, x1);
            double yy1 = Math.Max(y, y1) - Math.Min(y, y1);

            double distance = Math.Sqrt(xx1 * xx1 + yy1 * yy1);

            if (!(distance >= Math.Max(c1.r, c2.r)))
            {
                return true;
            }

            return false;

        }



        public static Circle Create()
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var circle = new Circle()
            {
                x = arr[0],
                y=arr[1],
                r=arr[2]
                
            };

            return circle;
        }
    }
}
