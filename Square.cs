using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    internal class Square : IShape
    {
        public int SideLenght {  get; set; }

        public Square(int side) 
        {
            SideLenght = side;
        }
        public double Area()
        {
            return SideLenght ^ 2;
        }

        public double Perimeter()
        {
            return SideLenght * 4;
        }
    }
}
