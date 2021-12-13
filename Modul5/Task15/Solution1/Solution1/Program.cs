using System;

namespace Solution1
{
    class Program
    {
        static void Main(string[] args)
        {
            Delete("I like like learn learn c#.");
        }

        static void Delete(string str)
        {
            string[] words = str.Split(' ');
            for (int i = 0; i < words.Length - 1; i++)
            {
                if (words[i] == words[i + 1])
                {
                    words[i] = string.Empty;
                }
            }

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == string.Empty)
                {
                    continue;
                }
                Console.Write(words[i] + " ");
            }

        }
    }
}