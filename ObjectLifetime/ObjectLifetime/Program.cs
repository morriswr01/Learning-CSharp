using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            //Car myThirdCar = new Car("Ford", "Escape", 2005, "White");
            Car.myMethod();
            
            /*    
            This is an instance of Car
            myCar.Make = "Oldsmobile";
            myCar.Model = "Cutlas Supreme";
            myCar.Year = 1986;
            myCar.Color = "Silver";
            
            Car myOtherCar;
            myOtherCar = myCar;

            Console.WriteLine("{0} {1} {2} {3}", myCar.Make, myCar.Model, myCar.Year, myCar.Color);
            Console.WriteLine("{0} {1} {2} {3}", myThirdCar.Make, myThirdCar.Model, myThirdCar.Year, myThirdCar.Color);
            myOtherCar.Model = "98";
            Console.WriteLine("{0} {1} {2} {3}", myOtherCar.Make, myOtherCar.Model, myOtherCar.Year, myOtherCar.Color);

            myOtherCar = null;
            This causes an exception because myOtherCar is no longer attatched to the "bucket" myCar in memory
            Console.WriteLine("{0} {1} {2} {3}", myOtherCar.Make, myOtherCar.Model, myOtherCar.Year, myOtherCar.Color);
            myCar = null;
            */

            Console.ReadLine();

        }
    }
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        /*
        public Car()
        {
            //You could load from config file to get obj into valid state
            Make = "Nissan";
        }


        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }
        */
        //Make is an instance property
        public static void myMethod()
        {
            Console.WriteLine(Make);
        }


    }
}
