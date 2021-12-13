using System;

namespace Solution1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Size of array: ");
            int size1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Size of array: ");
            int size2 = Convert.ToInt32(Console.ReadLine());


            int[,] array2D = new int[size1, size2];
            Random rand = new Random();

            for (int n = 0; n < size1; n++)
            {
                for (int m = 0; m < size2; m++)
                {
                    array2D[n, m] = rand.Next(100);
                }
                Console.WriteLine();
            }


            for (int i = 0; i < size1; i++)
            {
                for (int j = 0; j < size2; j++)
                {
                    Console.Write(array2D[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
