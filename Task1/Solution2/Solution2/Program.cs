using System;

namespace Solution2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Double variable:");
                double doubleValue = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Byte variable:");
                byte byteValue = Convert.ToByte(Console.ReadLine());

                Console.WriteLine("Char variable:");
                char charValue = Convert.ToChar(Console.ReadLine());

                Console.Write($"{doubleValue} ");
                Console.Write($"{charValue} ");
                Console.Write(byteValue);
            }
            catch
            {
                Console.WriteLine("Runtime error");
            }
            
        }
    }
}
