using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class AreaСalculator
    {
        public double CurrentArea { get; private set; }

        public void CalculateArea(IFigure figure)
        {
            CurrentArea = figure.GetArea();
        }
    }
}
