using System;

namespace CodingEnvironments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            var firstName = Console.ReadLine();
            Console.WriteLine("What is your second name?");
            var secondName = Console.ReadLine();
            var dateAndTime = DateTime.Now;
            Console.WriteLine($"Hello, {firstName} {secondName}, on {dateAndTime}");
        }
    }
}
