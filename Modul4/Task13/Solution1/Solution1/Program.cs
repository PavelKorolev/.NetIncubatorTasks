using System;

namespace Solution1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Number of elements:");
            int n = Convert.ToInt32((Console.ReadLine()));
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i + 1} element:");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int temp = 0;

            for (int write = 0; write < arr.Length; write++)
            {
                for (int sort = 0; sort < arr.Length - 1; sort++)
                {
                    if (arr[sort] > arr[sort + 1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
        }
    }
}
