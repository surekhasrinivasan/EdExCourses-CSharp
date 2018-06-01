using System;
using System.Collections.Generic;
using System.Text;

namespace Mod1_Assignment1
{
    public class UProgram
    {
        public Degree Degree1 { get; set; }
        
        public string PName { get; set; }

        public UProgram(String name, Degree degree1)
        {
            this.PName = name;
            this.Degree1 = degree1;
        }

        public UProgram()
        {

        }
    }
}
