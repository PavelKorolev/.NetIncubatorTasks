using System;

namespace Solution1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DayWithEnum(5));
        }

        public static DayOfWeek? DayWithEnum(int day)
        {
            if (day == 1)
            {
                return DayOfWeek.Monday;
            }
            else if (day == 2)
            {
                return DayOfWeek.Tuesday;
            }
            else if (day == 3)
            {
                return DayOfWeek.Wednesday;
            }
            else if (day == 4)
            {
                return DayOfWeek.Thursday;
            }
            else if (day == 5)
            {
                return DayOfWeek.Friday;
            }
            else if (day == 6)
            {
                return DayOfWeek.Saturday;
            }
            else if (day == 7)
            {
                return DayOfWeek.Sunday;
            }
           /* else if (day == 0)
            {
                return (DayOfWeek?)0;
            }*/
            else
            {
                return (DayOfWeek?)day;
            }
        }
    }
}
