using System;
using System.Collections.Generic;
using System.Text;

namespace Mod1_Assignment1
{
    public class Degree
    {
        public Course Course1 { get; set; }
        public String Name { get; set; }

        public Degree(Course course1, String name)
        {
            this.Course1 = course1;
            this.Name = name;
        }
    }
}
