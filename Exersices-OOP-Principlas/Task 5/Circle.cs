using System;
using System.Collections.Generic;
using System.Text;

namespace Task_5
{
    public class Circle: Shape
    {
        public Circle(double radius)
        {
            width = radius;
            height = radius;
        }

        public override double CalculateSurface()
        {
            return Math.PI * Math.Pow(width, 2);
        }
    }
}
