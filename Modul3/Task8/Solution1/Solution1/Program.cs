using System;

namespace Solution1
{
    class Program
    {
        static void Main(string[] args)
        {
            static int[] CalculateExpression(int a, int b)
            {
                int addition = a + b;
                int subtraction = a - b;
                int multiplication = a * b;
                int division = a / b;
               
                return new[] { addition, subtraction, multiplication, division, addition + subtraction + multiplication + division };
            }
            
            int[] mass = CalculateExpression(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write($"{mass[i]} ");
            }
        }
    }
}