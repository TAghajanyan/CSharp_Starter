using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Triangle
{
    class Triangle : Shape
    {
        public Triangle(int h, int w) : base(h, w)
        {
        }

        public double Area
        {
            get
            {
                return (Height * Width) / 2;
            }
        }
        public double Perimeter
        {
            get
            {
                return Height + Width + Math.Sqrt(Height * Height + Width * Width);
            }
        }

        public void Draw()
        {
            for (int i = 0; i < Height; i++)
            {
                int j = -1;
                while (i > j)
                {
                    Console.Write("*");

                    j++;
                }
                Console.WriteLine();

            }
        }
    }
}
