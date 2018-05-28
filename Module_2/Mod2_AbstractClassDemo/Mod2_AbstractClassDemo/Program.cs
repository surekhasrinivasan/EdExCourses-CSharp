using System;

namespace Mod2_AbstractClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee newEmp = new Employee();
            //newEmp.Login();

            Manager myManager = new Manager();
            myManager.Login();
            myManager.Hire();
        }
    }
}
