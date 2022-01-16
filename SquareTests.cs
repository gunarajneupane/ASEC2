using Xunit;
using PLEApp;
using drawing = System.Drawing;

namespace PLE_UnitTests
{
    public class SquareTests
    {
        /// <summary>
        /// Tests if a Square class validly forms
        /// </summary>
        [Fact]
        public void TestSquareDimensions()
        {
            Square square = new Square();
            square.set(drawing.Color.Blue, true, 0, 0, 10);

            int[] expectedValues = { 10 };
            int[] obtainedValues = { square.width };

            // validate results
            Assert.True(expectedValues[0] == obtainedValues[0], "Square did not correctly set its width!");
        }
    }
}
