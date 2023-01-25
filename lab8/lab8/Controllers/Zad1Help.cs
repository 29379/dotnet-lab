using System;
using System.Globalization;

namespace lab5zad1
{
    class Program
    {
        public static (float x1, float x2, string output, bool inf) CheckNumberOfSolutions(float a, float b, float c)
        {

            if (a == 0 && b == 0)
            {
                if (c == 0)
                {
                    return (float.NaN, float.NaN, "The equation has an infinite amount of solutions", true);
                }
                return (float.NaN, float.NaN, "The equation did not have any solutions", false);
            }
            else if (a == 0 && b != 0)
            {
                return LinearCase(b, c, false);
            }
            else
            {
                float delta_squared = MathF.Sqrt(b * b - 4 * a * c);

                if (delta_squared == 0)
                {
                    return SingleSolution(a, b, delta_squared, false);
                }
                else if (delta_squared > 0)
                {
                    return TwoSolutions(a, b, delta_squared, false);
                }
                else return (float.NaN, float.NaN, "The equation did not have any solutions", false);
            }
        }

        public static (float x1, float x2, string cmd_output, bool infCheck) SingleSolution(float a, float b, float delta_squared, bool inf)
        {
            float sol = (-b - delta_squared) / (2 * a);
            if (sol == -0)
            {
                sol = 0;
            }
            string output = $"The equation had only a single solution: {sol}";

            return (sol, float.NaN, output, inf);
        }

        public static (float x1, float x2, string cmd_output, bool infCheck) TwoSolutions(float a, float b, float delta_squared, bool inf)
        {
            float sol1 = (-b - delta_squared) / (2 * a);
            float sol2 = (-b + delta_squared) / (2 * a);
            if (sol1 == -0)
            {
                sol1 = 0;
            }
            if (sol2 == -0)
            {
                sol2 = 0;
            }
            string output = $"The equation had two solutions: {sol1.ToString("n5")} and {sol2.ToString("n5")}";
            return (sol1, sol2, output, inf);
        }

        public static (float x1, float x2, string cmd_output, bool infCheck) LinearCase(float a, float b, bool inf)
        {
            float sol = -b / a;
            if (sol == -0)
            {
                sol = 0;
            }
            string output = $"The equation had only a single solution: {sol}";
            return (sol, float.NaN, output, inf);
        }

        public static string GetEquationStr(float a, float b, float c)
        {
            string output = "f(x) = ";
            if (a == 0 && b == 0)
            {
                output += c.ToString();
            }
            else if (a == 0 && b != 0)
            {
                if (b == 1)
                {
                    output += "x";
                }
                else
                {
                    output += (b.ToString() + " * x");
                }
                if (c != 0)
                {
                    output += (" + " + c.ToString());
                }
            }
            else if (a != 0 && b == 0)
            {
                if (a == 1)
                {
                    output += "x^2";
                }
                else
                {
                    output += (a.ToString() + " * x^2");
                }
                if (c != 0)
                {
                    output += (" + " + c.ToString());
                }
            }
            else {
                if (a == 1)
                {
                    output += "x^2";
                }
                else
                {
                    output += a.ToString() + " * x^2";
                }

                if (b == 1)
                {
                    output += " + x";
                }
                else
                {
                    output += (" + " + b.ToString() + " * x");
                }

                if (c != 0)
                {
                    output += (" + " + c.ToString());
                }
            }
            return output;
        }

        /*
         public static void Main(string[] args)
        {
            var values = GetInput();
            (float x1, float x2, string output) = CheckNumberOfSolutions(values.Item1, values.Item2, values.Item3);
            Console.WriteLine(output);
        }
         */
    }
}
