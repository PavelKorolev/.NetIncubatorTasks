using System;

namespace Solution1
{
    class Program
    {

        static void Main(string[] args)
        {
            Menu(icecreams: 4, burgers:2, lattes: 1, tableSet: 2);
        }

        static void Menu(int burgers = 0, int lattes = 0, int icecreams = 0, int tableSet = 1)
        {
            Console.WriteLine($"\"You ordered {burgers} burgers, {lattes} lattes, {icecreams} ice creams.");
            Console.WriteLine($"Additional: {tableSet} table set\"");
        }
    }
}
