using System;

namespace Solution1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Have you done all your homework?");
            string firstAnswer = Console.ReadLine();

            Console.WriteLine("Did you make a team project?");
            string secondAnswer = Console.ReadLine();

            Console.WriteLine("If you have debt at university?");
            string thridAnswer = Console.ReadLine();

            if (firstAnswer  == "Yes" && secondAnswer == "Yes" && thridAnswer == "No")
            {
                Console.WriteLine("Today you can go for a walk with friends");
            }
            else
            {
                Console.WriteLine("You still have things to do");
            }
        }
    }
}
