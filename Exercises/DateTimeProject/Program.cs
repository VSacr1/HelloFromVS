using System;

namespace DateTimeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentDateandTime = DateTime.Now;
            Console.WriteLine(currentDateandTime);
            var currentDate = DateTime.Now.AddYears(5); 
            Console.Write(currentDate + "is a" + currentDate.DayOfWeek);
        }
    }
}
