using System;

namespace Solution1
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber, minNumber, buff; 
            
            Console.WriteLine("First number:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Second number:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

           if (firstNumber > secondNumber)
           {
                maxNumber = firstNumber;
                minNumber = secondNumber;

           }
           else
           {
                maxNumber = secondNumber;
                minNumber = firstNumber;
           }

            buff = minNumber;
            
            while (maxNumber > 0)
            {
                int digit1 = maxNumber % 10;
                
                while (minNumber > 0)
                {
                    int digit2 = minNumber % 10;
                    
                    if (digit1 == digit2)
                    {
                        Console.Write($"{digit1} ");
                    }
                    
                    minNumber /= 10;
                }
                
                minNumber = buff;
                maxNumber /= 10;
            }
        }
    }
}