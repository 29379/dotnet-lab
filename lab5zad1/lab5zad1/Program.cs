using System;
using System.Text;

namespace lab5zad1
{
    class Program
    {

        public static (float, float, float) GetInput()
        {
            float a = 0, b = 0, c = 0;
            Console.WriteLine("Enter the 'a' parameter");
            string inp1 = Console.ReadLine();
            if (float.TryParse(inp1, out float value1))
            {
                a = value1;
            }
            Console.WriteLine("Enter the 'b' parameter");
            string inp2 = Console.ReadLine();
            if (float.TryParse(inp2, out float value2))
            {
                b = value2;
            }
            Console.WriteLine("Enter the 'c' parameter");
            string inp3 = Console.ReadLine();
            if (float.TryParse(inp3, out float value3))
            {
                c = value3;
            }
            return (a, b, c);
        }

        public static (float x1, float x2, string output) CheckNumberOfSolutions(float a, float b, float c)
        {

            if (a == 0 && b == 0)
            {
                return (float.NaN, float.NaN, "The equation did not have any solutions");
            }
            else if (a == 0 && b != 0)
            {
                return LinearCase(b, c);
            }
            else
            {
                float delta_squared = MathF.Sqrt(b * b - 4 * a * c);

                if (delta_squared == 0)
                {
                    return SingleSolution(a, b, delta_squared);
                }
                else if (delta_squared > 0)
                {
                    return TwoSolutions(a, b, delta_squared);
                }
                else return (float.NaN, float.NaN, "The equation did not have any solutions");
            }
        }

        public static (float x1, float x2, string cmd_output) SingleSolution(float a, float b, float delta_squared)
        {
            float sol = (-b - delta_squared) / (2 * a);
            string output = $"The equation had only a single solution: {sol}";
            return (sol, float.NaN, output);
        }

        public static (float x1, float x2, string cmd_output) TwoSolutions(float a, float b, float delta_squared)
        {
            float sol1 = (-b - delta_squared) / (2 * a);
            float sol2 = (-b + delta_squared) / (2 * a);
            string output = $"The equation had two solutions: {sol1.ToString("n5")} and {sol2.ToString("n5")}";
            return (sol1, sol2, output);
        }

        public static (float x1, float x2, string cmd_output) LinearCase(float a, float b)
        {
            float sol = -b / a;
            string output = $"The equation had only a single solution: {sol}";
            return (sol, float.NaN, output);
        }

        public static void Main(string[] args)
        {
            var values = GetInput();
            (float x1, float x2, string output) = CheckNumberOfSolutions(values.Item1, values.Item2, values.Item3);
            Console.WriteLine(output);
        }
    }
}
