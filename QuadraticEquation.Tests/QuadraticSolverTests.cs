namespace QuadraticEquation.Tests
{
    public class QuadraticSolverTests
    {
        [Fact]
        public void Solve_PositiveDiscriminant_ReturnsTwoRoots()
        {
            Assert.Equal(new[] { 2.0, 1.0 }, QuadraticSolver.Solve(1, -3, 2));
        }

        [Fact]
        public void Solve_ZeroDiscriminant_ReturnsOneRoot()
        {
            Assert.Equal(new[] { -1.0 }, QuadraticSolver.Solve(1, 2, 1));
        }

        [Fact]
        public void Solve_NegativeDiscriminant_ReturnsNoRoots()
        {
            Assert.Empty(QuadraticSolver.Solve(1, 0, 4));
        }

        [Fact]
        public void Solve_ZeroA_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => QuadraticSolver.Solve(0, 1, 1));
        }

        [Fact]
        public void Discriminant_ReturnsBSquaredMinusFourAC()
        {
            Assert.Equal(-16.0, QuadraticSolver.Discriminant(1, 0, 4));
        }
    }
}
