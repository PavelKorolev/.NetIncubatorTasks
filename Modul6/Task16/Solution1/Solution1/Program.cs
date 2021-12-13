using System;

namespace Solution1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] AS;
            int count;
            string s;
            string[] AS2;

            count = Convert.ToInt32(Console.ReadLine());

            AS = new string[count];


            for (int i = 0; i < AS.Length; i++)
                AS[i] = Console.ReadLine() ?? string.Empty;



            for (int i = 0; i < AS.Length; i++)
            {
                if (AS[i] == string.Empty)
                {
                    AS[i] = "String is sempty";
                    //Console.WriteLine("String is empty");
                }
            }

            for (int i = 0; i < AS.Length; i++)
                Console.WriteLine(AS[i]); ;
        }
    }
}