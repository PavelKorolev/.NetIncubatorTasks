using System;

namespace Solution1
{
    class Program
    {
        static void Main(string[] args)
        {
            string variable = "Hello world!";
            
            int variable1 = 337;
            
            double variable2 = 1.55;
            
            Console.WriteLine(variable.GetHashCode());
            Console.WriteLine(nameof(variable) + " " + variable);

            Console.WriteLine(variable1.GetHashCode());
            Console.WriteLine(nameof(variable1) + " " + variable1);

            Console.WriteLine(variable2.GetHashCode());
            Console.WriteLine(nameof(variable2) + " " + variable2);

            object value1, value2, value3;
            value1 = 228;
            value2 = 228;
            value3 = value1;
            value1.Equals(value2);
            Console.WriteLine(value1.Equals(value2));
            ReferenceEquals(value2, value3);
        }
    }
}
