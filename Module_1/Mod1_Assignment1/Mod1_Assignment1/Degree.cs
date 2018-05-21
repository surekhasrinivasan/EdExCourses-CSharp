using System;
using System.Collections.Generic;
using System.Text;

namespace Mod1_Assignment1
{
    public class Degree
    {
        Course Course1 { get; set; }

        public Degree(Course course1)
        {
            this.Course1 = course1;
        }
    }
}
