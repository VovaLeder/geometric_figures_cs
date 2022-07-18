using GeomFigures;

namespace UnitTest_GeomFigures
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Initialization_Test()
        {
            double a = -1;
            double b = 4;
            double c = 5;

            Triangle triangle = new Triangle(a, b, c);
        }

        [TestMethod]
        public void GetPerimeter_Test()
        {
            double a = 3;
            double b = 4;
            double c = 5;

            Triangle triangle = new Triangle(a, b, c);

            double expected = a + b + c;
            double actual = triangle.getPerimeter();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetArea_Test()
        {
            double a = 1;
            double b = 1;
            double c = 1;

            Triangle triangle = new Triangle(a, b, c);

            double expected = Math.Sqrt(3) / 4;
            double actual = triangle.GetArea();

            Assert.AreEqual(expected, actual);
        }
    }
}