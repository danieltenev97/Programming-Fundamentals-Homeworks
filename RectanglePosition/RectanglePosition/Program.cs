using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectanglePosition
{
    class Program
    {
        static void Main(string[] args)
        {

            var fisrtRectangle = new RectangleProperties();

            fisrtRectangle = CreateRectangle();

            var secondRectangle = new RectangleProperties();

            secondRectangle = CreateRectangle();

            int a = fisrtRectangle.ReturnWidth();
            int b = fisrtRectangle.ReturnHeight();

            int a1 = secondRectangle.ReturnWidth();
            int b1 = secondRectangle.ReturnHeight();

            int width = fisrtRectangle.Left + a;
            int heigh = fisrtRectangle.Top + b;

           




        }


            

        public static RectangleProperties CreateRectangle()
        {
            int[] rectangleproperties = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var Rectangle = new RectangleProperties()
            {
                Left = rectangleproperties[0],
                Top = rectangleproperties[1],
                Width = rectangleproperties[2],
                Height = rectangleproperties[3]


            };

            return Rectangle;
        }
    }
}
