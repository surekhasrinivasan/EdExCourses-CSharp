using System;
using System.Collections.Generic;
using System.Text;

namespace Mod1_Assignment1
{
    public class Teacher
    {
        public string TeacherName { get; set; }
        public string Department { get; set; }
        public int YearsofExperience { get; set; }

        public Teacher(string tName, string dept, int yofExp)
        {
            this.TeacherName = tName;
            this.Department = dept;
            this.YearsofExperience = yofExp;
        }

    }
}
