using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo
{
    class Manager : Employee
    {
        private string department;

        public string Department
        {
            get { return department; }
            set { department = value; }
        }
    }
}
