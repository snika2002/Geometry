using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometryLibrary;

namespace UnitTest
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void TestArea()
        {
            Triangle triangle = new Triangle(6, 8, 10);
            triangle.Area();
        }

        [TestMethod]
        public void TestThisRectangularTrue()
        {
            Triangle triangle = new Triangle(6, 8, 10);
            triangle.ThisRectangular();
        }

        [TestMethod]
        public void TestThisRectangularFalse()
        {
            Triangle triangle = new Triangle(6, 4, 9);
            triangle.ThisRectangular();
        }
    }

    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void TestArea()
        {
            Circle circle = new Circle(5);
            circle.Area();
        }
    }

    [TestClass]
    public class CalculationTest
    {
        [TestMethod]
        public void TestCircleArea()
        {
            Circle circle = new Circle(5);
            Calculation.CalculateTheArea(circle);
        }

        [TestMethod]
        public void TestArea()
        {
            Triangle triangle = new Triangle(6, 8, 10);
            Calculation.CalculateTheArea(triangle);
        }

        [TestMethod]
        public void TestThisRectangularTrue()
        {
            Triangle triangle = new Triangle(6, 8, 10);
            Calculation.ThisRectangular(triangle);
        }

        [TestMethod]
        public void TestThisRectangularFalse()
        {
            Circle circle = new Circle(5);
            Calculation.ThisRectangular(circle);
        }
    }
}
