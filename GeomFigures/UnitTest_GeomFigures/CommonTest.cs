using GeomFigures;

namespace UnitTest_GeomFigures
{
    [TestClass]
    public class CommonTest
    {
        [TestMethod]
        public void Polymorphism_Test()
        {
            Figure[] figures = new Figure[2];
            figures[0] = new Triangle(3, 4, 5);
            figures[1] = new Circle(1);

            double[] answers = new double[2] {6, Math.PI };

            for (int i = 0; i < 2; i++ )
            {
                double expected = answers[i];
                double actual = figures[i].GetArea();

                Assert.AreEqual(expected, actual);
            }
        }

    }
}