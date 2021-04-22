using CarsInvetoryApp;
using System;
using System.Collections.Generic;

namespace CollectionsAndGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, int> scores = new Dictionary<string, int>();
            //scores.Add("John Doe", 67);
            //scores.Add("Peter Dude", 70);
            //scores.Add("Laila Gal", 99);
            //scores.Add("Gal Galdot", 85);
            //Console.WriteLine($"Before Remove: count={scores.Count}");
            //foreach (var score in scores)
            //{
            //    Console.WriteLine($"{score.Key} has a value of {score.Value}");
            //}

            //scores.Remove("Peter Dude");
            //Console.WriteLine($"After Remove: count={scores.Count}");
            //foreach (var score in scores)
            //{
            //    Console.WriteLine($"{score.Key} has a value of {score.Value}");
            //}
            //List<Car> cars = new List<Car>();
            //cars.Add(new Car { Make = "Toyota", Model = "CH-R", Year = 2021, CostPrice = 32000, SalePrice = 37500 });
            //cars.Add(new Car { Make = "Toyota", Model = "Aygo", Year = 2020, CostPrice = 16000, SalePrice = 19500 });
            //cars.Add(new Car { Make = "Toyota", Model = "Corolla", Year = 2015, CostPrice = 25000, SalePrice = 38500 });
            //foreach (var car in cars)
            //{
            //    Console.WriteLine(car.GetDetails());
            //}
            //Queue<Car> cars = new Queue<Car>();
            //cars.Enqueue(new Car { Make = "Toyota", Model = "CH-R", Year = 2021, CostPrice = 32000, SalePrice = 37500 });
            //cars.Enqueue(new Car { Make = "Toyota", Model = "Aygo", Year = 2020, CostPrice = 16000, SalePrice = 19500 });
            //cars.Enqueue(new Car { Make = "Toyota", Model = "Corolla", Year = 2015, CostPrice = 25000, SalePrice = 38500 });
            //Console.WriteLine("Original data");
            //foreach (var car in cars)
            //{
            //    Console.WriteLine(car.GetDetails());
            //}
            //DequeueAndPeek(cars);
            //DequeueAndPeek(cars);
            //DequeueAndPeek(cars);
            //Stack<Car> cars = new Stack<Car>();
            //cars.Push(new Car { Make = "Toyota", Model = "CH-R", Year = 2021, CostPrice = 32000, SalePrice = 37500 });
            //cars.Push(new Car { Make = "Toyota", Model = "Aygo", Year = 2020, CostPrice = 16000, SalePrice = 19500 });
            //cars.Push(new Car { Make = "Toyota", Model = "Corolla", Year = 2015, CostPrice = 25000, SalePrice = 38500 });
            //Console.WriteLine("Original data");
            //foreach (var car in cars)
            //{
            //    Console.WriteLine(car.GetDetails());
            //}
            //PopAndPeek(cars);
            //PopAndPeek(cars);
            //PopAndPeek(cars);

            Student<string> chris = new Student<string>() { Data = "Chris Jones" };
            Student<string> james = new Student<string>() { Data = "James Oliver" };
            Console.WriteLine(Check<string>.Compare(chris.Data, james.Data));

            Student<int> roger = new Student<int>() { Data = 123154654 };
            Student<int> kate = new Student<int>() { Data = 66879879 };
            Console.WriteLine(Check<int>.Compare(roger.Data, kate.Data));
        }

        //private static void PopAndPeek(Stack<Car> cars)
        //{
        //    try
        //    {
        //        Console.WriteLine("Popping");
        //        cars.Pop();
        //        Console.WriteLine($"First item is now: {cars.Peek().GetDetails()}");
        //    }
        //    catch
        //    {
        //        Console.WriteLine("Stack is now empty.");
        //        //Application Insights (Custom Logging - e)
        //    }
        //}

        //private static void DequeueAndPeek(Queue<Car> cars)
        //{
        //    try
        //    { 
        //        Console.WriteLine("Dequeing");
        //        cars.Dequeue();
        //        Console.WriteLine($"First item is now: {cars.Peek().GetDetails()}");
        //    }
        //    catch
        //    {
        //        Console.WriteLine("Queue is now empty.");
        //        //Application Insights (Custom Logging - e)
        //    }

        //}

        //Student<List<string>> firstStudent = new Student<List<string>>()
        //{
        //    Name = "James",
        //    Email = "james@newton.com",
        //    Phone = "012345",
        //    Subjects = new List<string>() { "Physics", "Chemistry", "Biology" }
        //};

        //Student<List<Car>> mechanicalStudent = new Student<List<Car>>()
        //{
        //    Name = "Smith",
        //    Email = "smith@nelson.com",
        //    Phone = "012345",
        //    Subjects = new List<Car> { new Car { Make = "Toyota", Model = "CH-R", Year = 2021, CostPrice = 32000, SalePrice = 37500 },
        //                new Car { Make = "Toyota", Model = "Aygo", Year = 2020, CostPrice = 16000, SalePrice = 19500 },
        //                new Car { Make = "Toyota", Model = "Corolla", Year = 2015, CostPrice = 25000, SalePrice = 38500 } }
        //};

        //Student<Car> carStudent = new Student<Car> { };

    }
    class Student<T>
    {
        public T Data { get; set; }
    }
    static class Check<T>
    {
        public static bool Compare(T firstValue, T secondValue)
        {
            if (firstValue.Equals(secondValue))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    //class Student<T>
    //{
    //    public string Name { get; set; }
    //    public string Email { get; set; }
    //    public string Phone { get; set; }
    //    public T Subjects { get; set; }
    //}

}
