namespace SquareEquationLib;

public class SquareEquation
{
    public static double[] Solve(double a, double b, double c)
    {
        double eps = 0.000000001;
        double[] Roots_Of_The_Equation;

        if (Math.Abs(a) < eps || new[] { a, b, c }.Any(double.IsNaN) || new[] { a, b, c }.Any(double.IsInfinity))
        {
            throw new ArgumentException();
        }

        double d = b * b - 4 * a * c;

        if (d < 0 && !(Math.Abs(d) < eps))
        {
            Roots_Of_The_Equation = new double[0];
        }
        else if (d < eps)
        {
            Roots_Of_The_Equation = new double[1];
            Roots_Of_The_Equation[0] = -(b + Math.Sign(b) * Math.Sqrt(d)) / 2;
        }
        else
        {
            Roots_Of_The_Equation = new double[2];
            Roots_Of_The_Equation[0] = -(b + Math.Sign(b) * Math.Sqrt(d)) / 2;
            Roots_Of_The_Equation[1] = c / Roots_Of_The_Equation[0];
        }
        return Roots_Of_The_Equation;
    } 
}