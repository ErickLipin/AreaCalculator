using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Figures
{
    public class Triangle : IFigure
    {
        private readonly double a;
        private readonly double b;
        private readonly double c;
        public bool IsRectangular { get; private set; }

        public Triangle(double inA, double inB, double inC)
        {
            a = inA;
            b = inB;
            c = inC;

            SetRectangular();
        }

        public double GetArea()
        {
            var halfP = (a + b + c) / 2;

            return Math.Sqrt(halfP * (halfP - a) * (halfP - b) * (halfP - c));            
        }

        private void SetRectangular() =>
            IsRectangular = ((a * a + b * b == c * c) || (a * a + c * c == b * b) || (c * c + b * b == a * a));        
    }
}
