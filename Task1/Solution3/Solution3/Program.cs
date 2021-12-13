using System;

namespace Solution3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("a = ");
                byte a = Convert.ToByte(Console.ReadLine());

                Console.WriteLine("b = ");
                byte b = Convert.ToByte(Console.ReadLine());

                byte c = checked(((byte)(a + b)));
                Console.WriteLine(c);
            }
            catch
            {
                Console.WriteLine("Runtime error");
            }
        }
    }
}
