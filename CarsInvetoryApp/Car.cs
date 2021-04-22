using System;

namespace CarsInvetoryApp
{
    public class Car
    {
        public Car()
        {
            Console.WriteLine("Here is our new car!");
        }
        public Car(string make, string model, int year)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public string Make { get; set; }

        public string Model { get; set; }
        public int Year { get; set; }
        public decimal CostPrice { get; set; }
        public decimal SalePrice { get; set; }

        public void Drive()
        {
            Console.WriteLine($"{Make} {Model} {Year} is in drive mode.");
        }
        public virtual void PowerUp()
        {
            Console.WriteLine($"{Make} {Model} {Year} energy ++.");
        }
    }
}
