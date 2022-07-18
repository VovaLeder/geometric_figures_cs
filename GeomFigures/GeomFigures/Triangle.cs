namespace GeomFigures
{
    /// <summary>
    /// Class <c>Triangle</c> models a triangle with positive sides
    /// </summary>
    public class Triangle: Figure
    {
        private double a;
        private double A
        {
            get { return a; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Triangle side must be positive.");
                }
                a = value;
            }
        }

        private double b;
        private double B
        {
            get { return b;}
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Triangle side must be positive.");
                }
                b = value;
            }
        }

        private double c;
        private double C
        {
            get { return c; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Triangle side must be positive.");
                }
                c = value;
            }
        }

        /// <summary>
        /// Constructor for <c>Triangle</c> class
        /// </summary>
        /// <param name="a">One of the triangles sides</param>
        /// <param name="b">One of the triangles sides</param>
        /// <param name="c">One of the triangles sides</param>
        public Triangle(double a, double b, double c)
        {
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new ArgumentException("There can not be triangle with that sides. Ensure that sum of lengths of any 2 sides is greater that length of the 3rd side.");
            }
            A = a;
            B = b;
            C = c;
        }

        /// <summary>
        /// Calculates a perimeter of a triangle
        /// </summary>
        /// <returns>Perimeter</returns>
        public double getPerimeter()
        {
            return A + B + C;
        }

        /// <summary>
        /// Calculates an area of a triangle
        /// </summary>
        /// <returns>Area</returns>
        public override double GetArea()
        {
            double semiPerimeter = getPerimeter() / 2;

            return Math.Sqrt(semiPerimeter * (semiPerimeter - A) * (semiPerimeter - B) * (semiPerimeter - C));
        }

        /// <summary>
        /// Checks if triangle rigth or not
        /// </summary>
        /// <returns><c>True</c> if triangle is right, <c>False</c> otherwise</returns>
        public bool IsRight()
        {
            double area = GetArea();
            if (A * B / 2 == area || A * C / 2 == area || B * C / 2 == area)
            {
                return true;
            }
            return false;
        }
    }
}