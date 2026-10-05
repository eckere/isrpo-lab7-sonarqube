namespace QuadraticEquation.Tests
{
    public class QuadraticSolverTests
    {
        [Fact]
        public void Solve_PositiveDiscriminant_ReturnsTwoRoots()
        {
            double[] roots = QuadraticSolver.Solve(1, -3, 2);
            Assert.Equal(2, roots.Length);
            Assert.Equal(2.0, roots[0]);
            Assert.Equal(1.0, roots[1]);
        }

        [Fact]
        public void Solve_ZeroDiscriminant_ReturnsOneRoot()
        {
            double root = Assert.Single(QuadraticSolver.Solve(1, 2, 1));
            Assert.Equal(-1.0, root);
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
