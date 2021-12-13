using System;

namespace Solution0
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("a = ");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.Write("b = ");
                byte b = Convert.ToByte(Console.ReadLine());

                Console.Write("c = ");
                char c = Convert.ToChar(Console.ReadLine());

                Console.Write($"{a} ");
                Console.Write($"{b} ");
                Console.Write(c);
            }
            catch
            {
                Console.WriteLine("Runtime error");
            }
        }
    }
}
