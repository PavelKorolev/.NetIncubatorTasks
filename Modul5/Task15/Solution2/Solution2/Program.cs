using System;

namespace Solution1
{
    class Program
    {
        static void Main(string[] args)
        {
            AddEndText("\"Hello, user! How are you?\"", "Fine!");
            InsertText("\"Hello, user! How are you?\"", "dear");
            RemoveText("\"Hello, user! How are you?\"");
            ReplaceText("\"Hello, user! How are you?\"");
        }

        static void AddEndText(string text, string subString)
        {
            text = text.Insert(text.Length, subString);
            Console.WriteLine(text);
        }

        static void InsertText(string text, string subString)
        {
            text = text.Insert(text.IndexOf(',') + 1, subString);
            Console.WriteLine(text);
        }

        static void RemoveText(string text)
        {
            text = text.Remove(text.IndexOf('!'), 1);
            Console.WriteLine(text);
        }

        static void ReplaceText(string text)
        {
            text = text.Replace("user", "programmer");
            Console.WriteLine(text);
        }
    }
}