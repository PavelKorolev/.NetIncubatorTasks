using System;

namespace Solution2
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseText("How are you?");
            //DeleteSpaces();
        }

        static void ReverseText(string text)
        {
            string txt = "";
            for (int i = text.Length - 1; i >= 0; i--)
            {
                txt += text[i];
            }
            Console.WriteLine(txt);
        }

        /*static void DeleteSpaces(string text)
        {
           
        }*/
    }
}