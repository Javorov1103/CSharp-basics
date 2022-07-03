using System;
using System.Collections.Generic;
using System.Text;

namespace Task_5
{
    public class Rectangle : Shape
    {
        public int SpecificRectangleProp { get; set; }
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double CalculateSurface()
        {
            return width * height;
        }
    }
}
