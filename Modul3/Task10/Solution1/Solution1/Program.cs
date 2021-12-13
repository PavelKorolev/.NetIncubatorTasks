using System;

namespace Solution1
{
    class Program
    {
        static int[] Swap(int firstNumber, int secondNumber)
        {
            int buff = 0;
            buff = firstNumber;
            firstNumber = secondNumber;
            secondNumber = buff;

            return new[] { firstNumber, secondNumber };
        }

        static void Main(string[] args)
        {
            int[] mass = Swap(5, 8);

            for (int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine(mass[i]);
            }
        }
    }
}
