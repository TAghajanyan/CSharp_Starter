using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Triangle
{
    class Shape
    {
        protected int Height { get; set; }
        protected int Width { get; set; }

        public Shape(int h, int w)
        {
            Height = h;
            Width = w;
        }
    }
}
