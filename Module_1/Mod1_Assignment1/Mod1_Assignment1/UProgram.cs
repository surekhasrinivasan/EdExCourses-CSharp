using System;
using System.Collections.Generic;
using System.Text;

namespace Mod1_Assignment1
{
    public class UProgram
    {
        Degree Degree1 { get; set; }

        public string PName { get; set; }

        public UProgram()
        {
            
        }

        public UProgram(Degree degree1)
        {
            this.Degree1 = degree1;
        }
    }
}
