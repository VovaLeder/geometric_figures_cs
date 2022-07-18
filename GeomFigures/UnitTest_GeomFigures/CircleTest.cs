using GeomFigures;

namespace UnitTest_GeomFigures
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Initialization_Test()
        {
            double radius = -1;

            Circle circle = new Circle(radius);
        }

        [TestMethod]
        public void GetArea_Test()
        {
            double radius = 3;

            Circle circle = new Circle(radius);

            double expected = radius * radius * Math.PI;
            double actual = circle.GetArea();

            Assert.AreEqual(expected, actual);
        }
    }
}