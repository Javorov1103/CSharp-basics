using System;
using System.Collections.Generic;
using System.Text;

namespace Task_5
{
    public class Triangle : Shape
    {
        public Triangle(double a, double h)
        {
            width = a;
            height = h;
        }
        public override double CalculateSurface()
        {
            return width * height / 2;
        }
    }
}
