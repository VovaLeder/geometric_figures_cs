namespace GeomFigures
{
    /// <summary>
    /// Class <c>Circle</c> models a circle with positive radius and calculatable area
    /// </summary>
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
        
        /// <summary>
        /// Constructor for <c>Circle</c> class
        /// </summary>
        /// <param name="radius">Radius of a circle</param>
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
