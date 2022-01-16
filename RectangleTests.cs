using Xunit;
using PLEApp;
using drawing = System.Drawing;

namespace PLE_UnitTests
{
    public class RectangleTests
    {
        /// <summary>
        /// Tests if a Rectangle class validly forms
        /// </summary>
        [Fact]
        public void TestRectangleDimensions() 
        {             
            Rectangle rectangle = new Rectangle();
            rectangle.set(drawing.Color.Blue, true, 0, 0, 10, 15);

            int[] expectedValues = { 10, 15 };
            int[] obtainedValues = { rectangle.width, rectangle.height };

            // validate results
            Assert.True(expectedValues[0] == obtainedValues[0], "Rectangle did not correctly set its width!");
            Assert.True(expectedValues[1] == obtainedValues[1], "Rectangle did not correclty set its height!");
        }
    }
}
