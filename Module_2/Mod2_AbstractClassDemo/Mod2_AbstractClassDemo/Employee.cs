﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Mod2_AbstractClassDemo
{
    abstract class Employee
    {
        public virtual void Login()
        {
            Console.WriteLine("Employee login");
        }

        public abstract void Hire();

        private string empNumber;
        private string firstName;
        private string lastName;
        private string address;

        public string EmpNumber
        {
            get { return empNumber; }
            set { empNumber = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
    }
}

