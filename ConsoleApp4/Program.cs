using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Въведете коефициентите на полинома, разделени с интервал: ");
        string input = Console.ReadLine();
        double[] coefficients = input.Split(' ').Select(double.Parse).ToArray();

        double[] roots = FindPolynomialRoots(coefficients);
        Console.WriteLine("Корените на полинома са: " + string.Join(", ", roots));
    }

    static double[] FindPolynomialRoots(double[] coefficients)
    {
        if (coefficients.Length == 3)  // Quadratic equation
        {
            double a = coefficients[0];
            double b = coefficients[1];
            double c = coefficients[2];
            double discriminant = b * b - 4 * a * c;

            if (discriminant > 0)
            {
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                return new double[] { root1, root2 };
            }
            else if (discriminant == 0)
            {
                double root = -b / (2 * a);
                return new double[] { root };
            }
            else
            {
                return new double[] { };
            }
        }
        else if (coefficients.Length == 2)  // Linear equation
        {
            double a = coefficients[0];
            double b = coefficients[1];
            if (a != 0)
            {
                return new double[] { -b / a };
            }
            else
            {
                return new double[] { };
            }
        }
        else
        {
            return new double[] { };
        }
    }
}
