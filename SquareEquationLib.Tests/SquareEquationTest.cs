using Xunit;
using SquareEquationLib;

namespace SquareEquationLib.Tests;

public class UnitTest1
{
    [Fact]
    public void Solve_Return2Roots()
    {
        double[] expected = new double[] { -5, -1 };
        double[] result = SquareEquation.Solve(1, 6, 5);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Solve_Return1Root()
    {
        double[] expected = new double[] { 3 };
        double[] result = SquareEquation.Solve(1, -6, 9);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Solve_ReturnEmpty()
    {
        double[] expected = new double[] { };
        double[] result = SquareEquation.Solve(1, 2, 5);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(0, 5, 8)]
    [InlineData(double.NaN, 2, 3)]
    [InlineData(1, double.PositiveInfinity, 3)]
    [InlineData(1, 2, double.NegativeInfinity)]
    public void Solve_ThrowsArgumentException(double a, double b, double c)
    {
        Assert.Throws<System.ArgumentException>(() => SquareEquation.Solve(a, b, c));
    }
}