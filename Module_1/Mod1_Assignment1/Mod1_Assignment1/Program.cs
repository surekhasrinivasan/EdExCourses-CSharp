using System;

namespace Mod1_Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            var Student1 = new Student();

            Student1.Name = "John Smith";
            Student1.Age = 22;

            var Student2 = new Student("Kathy Paul", 20);

            var Student3 = new Student("Jimmy Ray", 24);

            var uP = new UProgram();
            uP.PName = "Information Technology";

            int studentCount = Student.countStudents();

            Console.WriteLine($"Program name is {uP.PName}");
            Console.WriteLine($"There are {studentCount} students enrolled now");
            Console.WriteLine($"Student 1 is {Student1.Name} and his age is {Student1.Age}");
            Console.WriteLine($"Student 2 is {Student2.Name} and his age is {Student2.Age}");
        }
    }
}
