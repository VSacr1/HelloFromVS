using System;

namespace CarsInvetoryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car myKuga = new Car
            //{
            //    Make = "Ford",
            //    Model = "Kuga",
            //    Year = 2021,
            //    CostPrice = 35000,
            //    SalePrice = 40000
            //};
            //Car myTesla = new Car
            //{
            //    Make = "Tesla",
            //    Model = "Model S",
            //    Year = 2019,
            //    CostPrice = 45000,
            //    SalePrice = 50000
            //};
            //Console.WriteLine($"First Car: {myKuga.Make} {myKuga.Model} {myKuga.Year} costs {myKuga.CostPrice:C} and sells for {myKuga.SalePrice:C}.");
            //Console.WriteLine($"Second Car: {myTesla.Make} {myTesla.Model} {myTesla.Year} costs {myTesla.CostPrice:C} and sells for {myTesla.SalePrice:C}");
            Car myKuga = new Car(model: "Kuga", make: "Ford", year: 2021) { CostPrice = 30000, SalePrice = 35000 };
            int i= 123456;
            while (true)
            {
                Console.WriteLine($"First Car: {myKuga.Make} {myKuga.Model} {myKuga.Year} costs {myKuga.CostPrice:C} and sells for {myKuga.SalePrice:C}.");
                Console.WriteLine();
                Console.WriteLine(i++);
            }

        }
    }
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
    }
}
