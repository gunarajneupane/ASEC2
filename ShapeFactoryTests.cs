using Xunit;
using PLEApp;

namespace PLE_UnitTests
{
    public class ShapeFactoryTests 
    {
        /// <summary>
        /// Tests if a Rectangle class validly forms
        /// </summary>
        [Fact]
        public void TestShapeFactoryReturnTypes() 
        {
            ShapeFactory shapeFactory = new ShapeFactory();
            Shape rectShape = shapeFactory.createShape("rect");
            Shape circleShape = shapeFactory.createShape("circle");
            Shape squareShape = shapeFactory.createShape("square");
            Shape triangleShape = shapeFactory.createShape("triangle");
             
            // validate results
            Assert.True(rectShape is Rectangle, "ShapeFactory did not return Rectangle correctly.");
            Assert.True(circleShape is Circle, "ShapeFactory did not return Circle correctly.");
            Assert.True(squareShape is Square, "ShapeFactory did not return Square correctly.");
            Assert.True(triangleShape is Triangle, "ShapeFactory did not return Triangle correctly.");
        }
    }
}
