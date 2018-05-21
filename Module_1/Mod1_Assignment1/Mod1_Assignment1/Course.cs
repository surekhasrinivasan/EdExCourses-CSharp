using System;
using System.Collections.Generic;
using System.Text;

namespace Mod1_Assignment1
{
    public class Course
    {
        Student Student { get; set; }
        Teacher Teacher { get; set; }

        public Course(Student student1, Teacher teacher1)
        {
            this.Student = student1;
            this.Teacher = teacher1; 
        }
    }
}
