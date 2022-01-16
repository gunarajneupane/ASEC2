
using Xunit;
using PLEApp;
using drawing = System.Drawing;

namespace PLE_UnitTests
{
    public class CircleTests 
    {
        /// <summary>
        /// Tests if a Circle class validly forms
        /// </summary>
        [Fact]
        public void TestCircleDimensions() 
        {
            Circle rectangle = new Circle();
            rectangle.set(drawing.Color.Blue, true, 0, 0, 10);

            int[] expectedValues = { 10 };
            int[] obtainedValues = { rectangle.radius };

            // validate results
            Assert.True(expectedValues[0] == obtainedValues[0], "Circle did not correctly set its radius!");
        }
    }
}
