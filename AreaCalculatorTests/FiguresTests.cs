using System;
using Xunit;
using ClassLibrary.Figures;
using ClassLibrary;

namespace AreaCalculatorTests
{
    public class FiguresTests
    {
        [Fact]
        public void RectangularTriangleTest()
        {
            var triangle = new Triangle(3, 4, 5);

            Assert.True(triangle.IsRectangular);
        }

        [Fact]
        public void TriangleTest()
        {
            var triangle = new Triangle(16.38, 19.92, 10);

            Assert.False(triangle.IsRectangular);
        }
    }
}
