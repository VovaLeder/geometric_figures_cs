using GeomFigures;

namespace UnitTest_GeomFigures
{
    [TestClass]
    public class CircleTest
    {
        /// <summary>
        /// Trying to initialize a circle with negative radius
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Initialization_Test()
        {
            double radius = -1;

            Circle circle = new Circle(radius);
        }

        /// <summary>
        /// Checks the correctness of the calculation of the area of a circle
        /// </summary>
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