using System;
using System.Collections.Generic;

namespace School_Task
{
    public class Student
    {
        public readonly double gradePoint;
        private string lastName;
        private string name;
        private int schoolNumber;

        private static int numberOfStudents = 0;
        private static double pointsSum = 0;
        private static double pointsAverage;

        static Student()
        {
            Console.WriteLine($"Static constructor execution {numberOfStudents}");
        }

        public Student(string LastName, string Name, double GradePoint, int SchoolNumber = 51)
        {
            lastName = LastName;
            name = Name;
            gradePoint = GradePoint;
            schoolNumber = SchoolNumber;

            numberOfStudents++;
            pointsSum += GradePoint;
            Console.WriteLine($"Default constructor execution {numberOfStudents}");
        }

        public static void DisplayStudentsCount()
        {
            Console.WriteLine(numberOfStudents);
        }

        public static double CountAverage()
        {
            pointsAverage = pointsSum / numberOfStudents;
            return pointsAverage;
        }

        public override string ToString()
        {
            return $"{lastName} {name} {gradePoint}";
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            List<Student> students = new();

            for (int i = 0; i < N; i++)
            {
                string LastName = Console.ReadLine();
                string Name = Console.ReadLine();
                double GradePoint = double.Parse(Console.ReadLine().Replace('.', ','));
                Student tmpStudent = new Student(LastName, Name, GradePoint);
                students.Add(tmpStudent);
            }
            Console.WriteLine(Student.CountAverage());
            foreach (var student in students)
            {
                if (student.gradePoint < Student.CountAverage())
                {
                    Console.WriteLine(student.ToString());
                }
            }
        }
    }
}