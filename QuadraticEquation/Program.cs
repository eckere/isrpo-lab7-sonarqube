using System.Globalization;

namespace QuadraticEquation
{
    public static class Program
    {
        public static void Main()
        {
            Run(Console.In, Console.Out);
        }

        public static void Run(TextReader input, TextWriter output)
        {
            output.WriteLine("Решение квадратного уравнения a*x^2 + b*x + c = 0");

            double a = ReadCoefficient("a", input, output);
            double b = ReadCoefficient("b", input, output);
            double c = ReadCoefficient("c", input, output);

            if (QuadraticSolver.IsZero(a))
            {
                output.WriteLine("Коэффициент a не должен быть равен 0");
                return;
            }

            output.WriteLine("Дискриминант D = " + QuadraticSolver.Discriminant(a, b, c));

            double[] roots = QuadraticSolver.Solve(a, b, c);
            switch (roots.Length)
            {
                case 0:
                    output.WriteLine("Действительных корней нет");
                    break;
                case 1:
                    output.WriteLine("Корень: x = " + roots[0]);
                    break;
                default:
                    output.WriteLine("Корни: x1 = " + roots[0] + ", x2 = " + roots[1]);
                    break;
            }
        }

        public static double ReadCoefficient(string name, TextReader input, TextWriter output)
        {
            while (true)
            {
                output.Write("Введите коэффициент " + name + ": ");
                string? line = input.ReadLine();
                if (line == null)
                {
                    throw new InvalidOperationException("Ввод данных прерван");
                }
                if (double.TryParse(line, NumberStyles.Float, CultureInfo.CurrentCulture, out double value))
                {
                    return value;
                }
                output.WriteLine("Ошибка: введите число");
            }
        }
    }
}
