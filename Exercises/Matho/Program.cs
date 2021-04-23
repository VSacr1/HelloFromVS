using System;

namespace Matho
{
    class Program
    {
        static void Main(string[] args)
        {
            //var maxValue = Math.Max(234, 433);
            //Console.WriteLine(maxValue);
            //var minValue = Math.Min(234, 433);
            //Console.WriteLine(minValue);
            //float myFloat = 123.6F;
            //Console.WriteLine(Math.Round(myFloat));
            var calculation = Math.Pow(3, 2) + Math.Pow(4, 2);
            Console.WriteLine(calculation);
            var result = Math.Sqrt(calculation);
            Console.WriteLine(result);
        }
    }
}
