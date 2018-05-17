using System;
using System.Collections.Generic;
using System.Text;

namespace class_demo
{
    class DrinksMachine
    {
        public DrinksMachine(string loc, string make, string model)
        {
            this.Location = loc;
            this.Make = make;
            this.Model = model;
        }
        //The following statements declare private member variables 
        private string _location;
        private string _make;
        private string _model;

        public string Location { get => _location; set => _location = value; }
        public string Make { get => _make; set => _make = value; }
        public string Model { get => _model; set => _model = value; }

        public void MakeCappuccino()
        {
            Console.WriteLine("Cappuccino is made.");
        }
        public void MakeEspresso()
        {
            // Method logic goes here.
        }
    }
}
