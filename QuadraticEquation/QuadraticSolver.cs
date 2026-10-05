namespace QuadraticEquation
{
    public static class QuadraticSolver
    {
        private const double Epsilon = 1e-9;

        public static bool IsZero(double value)
        {
            return Math.Abs(value) < Epsilon;
        }

        public static double Discriminant(double a, double b, double c)
        {
            return b * b - 4 * a * c;
        }

        public static double[] Solve(double a, double b, double c)
        {
            if (IsZero(a))
            {
                throw new ArgumentException("Коэффициент a не должен быть равен 0", nameof(a));
            }

            double discriminant = Discriminant(a, b, c);
            if (discriminant < -Epsilon)
            {
                return Array.Empty<double>();
            }
            if (IsZero(discriminant))
            {
                return new[] { -b / (2 * a) };
            }

            double sqrtD = Math.Sqrt(discriminant);
            return new[] { (-b + sqrtD) / (2 * a), (-b - sqrtD) / (2 * a) };
        }
    }
}
