using System;

namespace Overloader
{
    class Program
    {
        static void Main(string[] args)
        {
            float inputBaseValue = 5, inputMuplitplier = 2;
            Console.WriteLine($"Before: {inputBaseValue}");
            MultiplyVar(ref inputBaseValue, inputMuplitplier);
            Console.WriteLine($"After: {inputBaseValue}");
        }

        static void MultiplyVar(ref float baseValue, float multiplier)
        {
            baseValue *= multiplier;
        }
        static double Add(double firstValue, double secondValue)
        {
            return firstValue + secondValue;
        }
        static double Subtract(double firstValue, double secondValue)
        {
            return firstValue - secondValue;
        }
        static double Multiply(double firstValue, double secondValue)
        {
            return firstValue * secondValue;
        }
        static double Divide(double firstValue, double secondValue)
        {
            return firstValue / secondValue;
        }
    }
}
