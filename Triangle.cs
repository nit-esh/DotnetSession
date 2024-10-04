using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    internal class Triangle : IShape
    {

        public int Base {  get; set; }
        public int Height { get; set; }

        public Triangle(int side, int height)
        {
            Base = side;
            Height = height;
        }

        public double Area()
        {
            return 0.5*Base*Height;
        }

        public double Perimeter()
        {
            return Base+Height*2;
        }
    }
}
