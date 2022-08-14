using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Figures
{
    public class Circle: IFigure
    {
        private readonly double radius;
        public Circle(double inRadius)
        {
            radius = inRadius;
        }
        public double GetArea() => radius * radius * Math.PI;
    }
}
