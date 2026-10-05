using System.Globalization;

namespace QuadraticEquation
{
    static class Program
    {
        private const double Epsilon = 1e-9;

        static void Main()
        {
            Console.WriteLine("Решение квадратного уравнения a*x^2 + b*x + c = 0");

            double a = ReadCoefficient("a");
            double b = ReadCoefficient("b");
            double c = ReadCoefficient("c");

            if (Math.Abs(a) < Epsilon)
            {
                Console.WriteLine("Коэффициент a не должен быть равен 0");
                return;
            }

            double discriminant = b * b - 4 * a * c;
            Console.WriteLine("Дискриминант D = " + discriminant);

            if (discriminant < -Epsilon)
            {
                Console.WriteLine("Действительных корней нет");
            }
            else if (Math.Abs(discriminant) < Epsilon)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Корень: x = " + x);
            }
            else
            {
                double sqrtD = Math.Sqrt(discriminant);
                double x1 = (-b + sqrtD) / (2 * a);
                double x2 = (-b - sqrtD) / (2 * a);
                Console.WriteLine("Корни: x1 = " + x1 + ", x2 = " + x2);
            }
        }

        static double ReadCoefficient(string name)
        {
            while (true)
            {
                Console.Write("Введите коэффициент " + name + ": ");
                string? input = Console.ReadLine();
                if (input == null)
                {
                    throw new InvalidOperationException("Ввод данных прерван");
                }
                if (double.TryParse(input, NumberStyles.Float, CultureInfo.CurrentCulture, out double value))
                {
                    return value;
                }
                Console.WriteLine("Ошибка: введите число");
            }
        }
    }
}
