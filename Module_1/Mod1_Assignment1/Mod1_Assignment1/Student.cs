using System;
using System.Collections.Generic;
using System.Text;

namespace Mod1_Assignment1
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        private static int students = 0;

        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            students++;
        }
        public Student()
        {
            students++;
        }

        public static int countStudents()
        {
            return students;
        }
    }
}
