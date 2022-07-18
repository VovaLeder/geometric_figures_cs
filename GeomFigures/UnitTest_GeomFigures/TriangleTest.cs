using GeomFigures;

namespace UnitTest_GeomFigures
{
    [TestClass]
    public class TriangleTest
    {
        /// <summary>
        /// Trying to initialize a triangle with negative side
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Initialization_Test1()
        {
            double a = -1;
            double b = 4;
            double c = 5;

            Triangle triangle = new Triangle(a, b, c);
        }

        /// <summary>
        /// Trying to initialize a triangle with negative side
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Initialization_Test2()
        {
            double a = 3;
            double b = -1;
            double c = 5;

            Triangle triangle = new Triangle(a, b, c);
        }

        /// <summary>
        /// Trying to initialize a triangle with negative side
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Initialization_Test3()
        {
            double a = 3;
            double b = 4;
            double c = -1;

            Triangle triangle = new Triangle(a, b, c);
        }

        /// <summary>
        /// Checks the correctness of the calculation of the perimeter of a triangle
        /// </summary>
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

        /// <summary>
        /// Checks the correctness of the calculation of the area of a triangle
        /// </summary>
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

        /// <summary>
        /// Checks the correctness of the calculation of the rightness of a triangle (expected to be right)
        /// </summary>
        [TestMethod]
        public void IsRight_Test1()
        {
            double a = 3;
            double b = 4;
            double c = 5;

            Triangle triangle = new Triangle(a, b, c);

            bool expected = true;
            bool actual = triangle.IsRight();

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Checks the correctness of the calculation of the rightness of a triangle (expected to be not right)
        /// </summary>
        [TestMethod]
        public void IsRight_Test2()
        {
            double a = 3;
            double b = 4;
            double c = 6;

            Triangle triangle = new Triangle(a, b, c);

            bool expected = false;
            bool actual = triangle.IsRight();

            Assert.AreEqual(expected, actual);
        }
    }
}