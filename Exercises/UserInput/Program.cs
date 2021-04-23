using System;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int userInput = int.Parse(Console.ReadLine());
            for (int i = userInput; i >= 1; i--)
            {
                Console.WriteLine($"Countdown: {i}");
            }
            Console.WriteLine($"Countdown: Done!");
        }
    }
}
