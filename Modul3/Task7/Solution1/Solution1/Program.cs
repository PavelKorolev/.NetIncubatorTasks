using System;

namespace Solution1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] mass = CalculateExpression(15.2 , 3.8);
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write($"{mass[i]} ");
            }
        }

        static double[] CalculateExpression(double a, double b)
        {
            double addition = a + b;
            double subtraction = a - b;
            double multiplication = a * b;
            double division = a / b;
            return new[] { addition, subtraction, multiplication, division, addition + subtraction + multiplication + division };
        }
    }
}
