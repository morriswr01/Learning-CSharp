using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //A class is a set of rules you write that govern an object. You can have more than one class involved in creating an object through inheritance.
            //An object, or instance, or instance object, or class object, or whatever, is what a class defines. When you actually use that class to make a THING, this is what you make.
            //A method is a bit of code that can be called when needed(often as part of an class, but not always)

            Car myCar = new Car();
            myCar.Make = "Oldsmobile";
            myCar.Model = "Cutlas Supreme";
            myCar.Year = 1986;
            myCar.Color = "Silver";

            Console.WriteLine("{0} {1} {2} {3}", myCar.Make, myCar.Model, myCar.Year, myCar.Color);
            Console.ReadLine();

        }
    }
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

    }
}
