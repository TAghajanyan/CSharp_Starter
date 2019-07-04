using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Triangle
{
    class Rectangle : Shape
    {
        public Rectangle(int h, int w) : base(h, w)
        {
        }

        public double Area
        {
            get
            {
                return Height * Width;
            }
        }

        public double Perimeter
        {
            get
            {
                return 2 * (Height + Width);
            }
        }

        public void Draw()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
