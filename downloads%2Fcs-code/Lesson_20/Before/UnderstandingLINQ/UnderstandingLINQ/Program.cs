using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>() {
                new Car() { VIN="A1", Make = "BMW", Model= "550i", StickerPrice=55000, Year=2009},
                new Car() { VIN="B2", Make="Toyota", Model="4Runner", StickerPrice=35000, Year=2010},
                new Car() { VIN="C3", Make="BMW", Model = "745li", StickerPrice=75000, Year=2008},
                new Car() { VIN="D4", Make="Ford", Model="Escape", StickerPrice=25000, Year=2008},
                new Car() { VIN="E5", Make="BMW", Model="55i", StickerPrice=57000, Year=2010}
            };

            // LINQ Query
            /*
            var bmws = from car in myCars
                       where car.Make == "BMW"
                       && car.Year == 2010
                       select car;
                       */

            //var orderedCars = from car in myCars
            //                  orderby car.Year descending
            //                  select car;
            // LINQ Method

            //Cars where make is BMW and year is 2010
            //var bmws = myCars.Where(p =>p.Make == "BMW" && p.Year == 2010);



            // Puts in decending order and then finds First bmw in list, methods are chained
            //var firstBMW = myCars.OrderByDescending(p => p.Year).First(p => p.Make == "BMW");
            //Console.WriteLine(firstBMW.VIN);

            //Checks whether all are above a certain parameter
            //Console.WriteLine(myCars.TrueForAll(p => p.Year > 2012));

            //myCars.ForEach(p => p.StickerPrice -= 3000);
            //myCars.ForEach(p => Console.WriteLine("{0} {1:C}", p.VIN, p.StickerPrice));


            //Finds whether an item is in list
            //Console.WriteLine(myCars.Exists(p => p.Model == "745li"));

            //Console.WriteLine(myCars.Sum(p => p.StickerPrice));

            /*
            foreach (var car in orderedCars)
            {
                Console.WriteLine("{0} {1} {2}", car.Year, car.Model, car.VIN);
            }
            */

            //Cars in order of year
            //var orderedCars = myCars.OrderByDescending(p => p.Year);
            //Console.WriteLine(orderedCars.GetType());
            //Console.WriteLine(myCars.GetType());

            var newCars = from car in myCars
                       where car.Make == "BMW"
                       && car.Year == 2010
                       select new { car.Make car.Model };

            Console.WriteLine(newCars.GetType());

            Console.ReadLine();
        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }
    }
}
