using System;
using Xunit;
using ClassLibrary.Figures;
using ClassLibrary;

namespace AreaCalculatorTests
{
    public class AreaŅalculatorTests
    {
        [Fact]
        public void CircleTest()
        {
            var calculator = new AreaŅalculator();
            var circle = new Circle(5);

            calculator.CalculateArea(circle);

            Assert.Equal(78.539816339744831, calculator.CurrentArea);

        }

        [Fact]
        public void TriangleTest()
        {
            var calculator = new AreaŅalculator();
            var triangle = new Triangle(16.38, 19.92, 10);

            calculator.CalculateArea(triangle);

            Assert.Equal(81.589443249417954, calculator.CurrentArea);
        }
    }
}
