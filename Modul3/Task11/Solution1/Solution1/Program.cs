using System;

namespace Solution1
{
    class Program
    {

        static void Main(string[] args)
        {
            fullName("Conor", "", "McGregor");
        }

        static void fullName(string firstName, string middleName, string lastName)
        {
            Console.WriteLine($"{firstName}{middleName} {lastName}");
        }
    }
}
