namespace GeomFigures
{
    public class Circle : Figure
    {
        private double radius;
        public double Radius
        {
            get { return radius; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Circle radius must be positive.");
                }
                radius = value;
            }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
