namespace GeomFigures
{
    public class Triangle: Figure
    {
        private double a;
        public double A
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
        public double B
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
        public double C
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

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double getPerimeter()
        {
            return A + B + C;
        }

        public override double GetArea()
        {
            double semiPerimeter = getPerimeter() / 2;

            return Math.Sqrt(semiPerimeter * (semiPerimeter - A) * (semiPerimeter - B) * (semiPerimeter - C));
        }

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