using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_8
{
    class Program
    {
       static void Main(string[] args)
      {

      }

        public struct Rectangle
         {
            public int height;
            public int width;
            public int x;
            public int y;

            public Rectangle (int height1, int width1, int x1, int y1)
            {
                height = height1;
                width = width1;
                x = x1;
                y = y1;
            }
         }
        
    }
}
