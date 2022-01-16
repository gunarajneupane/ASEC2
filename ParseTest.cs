using System.Text;
using PLEApp;
using Xunit;

namespace PLE_UnitTests
{
    /// <summary>
    /// A Test class for Parse.cs
    /// </summary>
    public class ParseTest
    {
        /// <summary>
        /// tests if parse line successfully updates the canvas object from given instructions
        /// </summary>
        [Fact]
        public void TestParseDrawTo()
        {
         //   parseLine(String line, Canvas displayCanvas, StringBuilder errorList, int numLine)

            Canvas myCanvas = new Canvas();
            Parse parser = new Parse();

            parser.parseLine(new StringBuilder(),myCanvas, "drawto 200,100", 1);

            int[] expectedValues = { 200,100 };
            int[] obtainedValues = { myCanvas.x, myCanvas.y };

            //run test
            Assert.True(expectedValues[0] == obtainedValues[0], "Parser did not correctly draw the point in the specified x coordinate!");
            Assert.True(expectedValues[1] == obtainedValues[1], "Parser did not correctly draw the point in the specified y coordinate!");
        }

        /// <summary>
        /// tests if parse line successfully updates the canvas object from given instructions
        /// </summary>
        [Fact]
        public void TestParseMoveTo()
        {
            //   parseLine(String line, Canvas displayCanvas, StringBuilder errorList, int numLine)

            Canvas myCanvas = new Canvas();
            Parse parser = new Parse();

            parser.parseLine(new StringBuilder(), myCanvas, "moveto 200,100", 1);

            int[] expectedValues = { 200, 100 };
            int[] obtainedValues = { myCanvas.x, myCanvas.y };

            //run test
            Assert.True(expectedValues[0] == obtainedValues[0], "Parser did not correctly move to the specified x coordinate!");
            Assert.True(expectedValues[1] == obtainedValues[1], "Parser did not correctly move to the specified y coordinate!");
        }
    }
}
