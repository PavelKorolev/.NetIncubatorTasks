using System;

namespace Solution1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, value;

            Console.WriteLine("First number:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Second number:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
               number = firstNumber;
               value = secondNumber;
            }
            else
            {
                number = secondNumber;
                value = firstNumber;
            }

            for (int i = value; i <= number; i++)
            {
                if (i % 2 == 1 || i % 2 == -1)
                    continue;
                
                Console.Write($"{i} ");
            }
        }
    }
}
