using System;

namespace Solution1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count;
            double?[] ages;
            double average = 0;

            count = Convert.ToInt32(Console.ReadLine());

            ages = new double?[count];


            for (int i = 0; i < ages.Length; i++)
            {
                string str = Console.ReadLine();
                if (str == string.Empty)
                {
                    ages[i] = null;
                    count--;
                }
                else
                {
                    ages[i] = Convert.ToDouble(str);
                }
            }

            for (int i = 0; i < ages.Length; i++)
            {
                if (ages[i] == null)
                {
                    continue;
                }

                average += (double)ages[i];
            }

            Console.WriteLine(Math.Round(average / count, 2));

        }
    }
}