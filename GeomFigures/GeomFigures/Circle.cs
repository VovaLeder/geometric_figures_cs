namespace GeomFigures
{
    internal class Circle : Figure
    {
        double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }
}
