using System;

namespace Dealership {
    class Car
    {
        private string MakeModel;
        private int Price;
        private int Miles;
        private string Message;

        public Car(string makeModel, int price, int miles, string message)
        {
            MakeModel = makeModel;
            Price = price;
            Miles = miles;
            Message = message;
        }

        public string GetMakeModel()
        {
            return MakeModel;
        }

        public int GetPrice()
        {
            return Price;
        }

        public void SetPrice(int newPrice)
        {
            Price = newPrice;
        }

        public int GetMiles()
        {
            return Miles;
        }

        public string GetMessage()
        {
            return Message;
        }

        public bool WorthBuying(int maxPrice, int maxMileage)
        {
            return (Price <= maxPrice && Miles <= maxMileage);
        }
    }
}
