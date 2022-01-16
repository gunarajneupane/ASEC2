using Xunit;
using PLEApp;
using drawing = System.Drawing;

namespace PLE_UnitTests
{
    public class TriangleTests  
    {
        /// <summary>
        /// Tests if a Triangle class validly forms
        /// </summary>
        [Fact]
        public void TestTriangleDimensions()
        {
            Triangle triangle = new Triangle();
            triangle.set(drawing.Color.Blue, true, 0, 0, 10, 15, 20);

            int[] expectedValues = { 10, 15, 20 };
            int[] obtainedValues = { triangle.hypotenuse, triangle.breadth, triangle.perpendicular };

            // validate results
            Assert.True(expectedValues[0] == obtainedValues[0], "Triangle did not correclty set its hypotenuse!");
            Assert.True(expectedValues[1] == obtainedValues[1], "Triangle did not correclty set its breadth!");
            Assert.True(expectedValues[2] == obtainedValues[2], "Triangle did not correclty set its perpendicular!");
        }
    }
}