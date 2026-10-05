namespace QuadraticEquation.Tests
{
    public class ProgramTests
    {
        private static string RunWithInput(string text)
        {
            using var input = new StringReader(text);
            using var output = new StringWriter();
            Program.Run(input, output);
            return output.ToString();
        }

        [Fact]
        public void Run_TwoRoots_PrintsBothRoots()
        {
            Assert.Contains("Корни: x1 = 2, x2 = 1", RunWithInput("1\n-3\n2\n"));
        }

        [Fact]
        public void Run_OneRoot_PrintsSingleRoot()
        {
            Assert.Contains("Корень: x = -1", RunWithInput("1\n2\n1\n"));
        }

        [Fact]
        public void Run_NoRoots_PrintsMessage()
        {
            Assert.Contains("Действительных корней нет", RunWithInput("1\n0\n4\n"));
        }

        [Fact]
        public void Run_ZeroA_PrintsError()
        {
            Assert.Contains("Коэффициент a не должен быть равен 0", RunWithInput("0\n1\n1\n"));
        }

        [Fact]
        public void Run_InvalidNumber_AsksAgain()
        {
            Assert.Contains("Ошибка: введите число", RunWithInput("abc\n1\n-3\n2\n"));
        }

        [Fact]
        public void Run_InputEnded_ThrowsException()
        {
            Assert.Throws<InvalidOperationException>(() => RunWithInput("1\n"));
        }
    }
}
