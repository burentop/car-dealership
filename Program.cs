using System;
using System.Collections.Generic;

namespace Dealership {
    public class Program
    {
        public static void Main()
        {
            Car porsche = new Car("2014 Porsche 911", 114991, 7864, "It's a doozy!");
            Car ford = new Car("2011 Ford F450", 55995, 14241, "For when you need a big truck.");
            Car lexus = new Car("2013 Lexus RX 350", 44700, 20000, "If you wanna be like everyone else");
            Car mercedes = new Car("Mercedes Benz CLS550", 39900, 37979, "A decent bargain.");
            
            List<Car> Cars = new List<Car>() { porsche, ford, lexus, mercedes };

            lexus.SetPrice(2000);

            Console.WriteLine("Enter maximum price: ");
            string stringMaxPrice = Console.ReadLine();
            int maxPrice = int.Parse(stringMaxPrice);

            Console.WriteLine("Enter maximum mileage: ");
            string stringMaxMileage = Console.ReadLine();
            int maxMileage = int.Parse(stringMaxMileage);

            List<Car> CarsMatchingSearch = new List<Car>();

            foreach (Car automobile in Cars)
            {
                if (automobile.WorthBuying(maxPrice, maxMileage))
                {
                    CarsMatchingSearch.Add(automobile);
                }
            }

            foreach (Car automobile in CarsMatchingSearch)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine(automobile.GetMakeModel());
                Console.WriteLine(automobile.GetMiles() + " miles");
                Console.WriteLine("$" + automobile.GetPrice());
                Console.WriteLine(automobile.GetMessage());
            }
        }
    }
}
