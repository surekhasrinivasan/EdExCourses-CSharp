using System;

namespace Mod1_Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiating an object of Car() class by using Type Inference called Car1
            var Car1 = new Car();

            //Using dot notation to call members on Car1
            Car1.Color = "White";
            Car1.Year = 2010;
            Car1.Mileage = 11000;

            //Instantianting another object of Car() class by using Type Inference called Car2
            var Car2 = new Car("Red", 2008);

            //Access static members 
            int carCount = Car.CountCars();

            //output to the console window
            Console.WriteLine($"There are {carCount} cars on inventory right now.");
        }
    }
}
