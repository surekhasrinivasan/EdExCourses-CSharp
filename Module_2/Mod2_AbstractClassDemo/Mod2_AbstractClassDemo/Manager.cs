using System;
using System.Collections.Generic;
using System.Text;

namespace Mod2_AbstractClassDemo
{
    class Manager : Employee
    {
        public override void Login()
        {
            Console.WriteLine("Manager Login");
        }
        public override void Hire()
        {
            Console.WriteLine("Hire someone");
        }
        //private string department;
    }
}
