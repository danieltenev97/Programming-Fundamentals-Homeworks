using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectanglePosition
{
    class RectangleProperties
    {
       public int Left { get; set; }
      public  int Top { get; set; }
       public int Width { get; set; }
       public int Height { get; set; }

        public int ReturnWidth()
        {
            return Left + Width;
        }

        public int ReturnHeight()
        {
            return Top+Height;
        }

       


        }
}
