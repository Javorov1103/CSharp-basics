using System;
using System.Collections.Generic;
using System.Text;

namespace Task_5
{
    public abstract class Shape
    {
        internal double width;
        internal double height;
        public virtual double CalculateSurface()
        {
            return 10000;
        }
    }
}
