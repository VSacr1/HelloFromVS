using System;
using System.Collections.Generic;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.
            //Console.WriteLine("Enter a number:");
            //int A = int.Parse(Console.ReadLine());
            //while (A < 200)
            //{
            //    Console.WriteLine(A);
            //    A++;
            //}
            //2.
            //Console.WriteLine("Enter a number:");
            //int A = int.Parse(Console.ReadLine());
            ////for (int i = A; i <= 200; i++)
            ////{
            ////    //if (A % 2 == 0)
            ////    //    Console.WriteLine("-");
            ////    //else
            ////    //    Console.WriteLine("*");
            ////    string firstPrintOut = i % 2 == 0 ? "-" : "*";
            ////    Console.WriteLine(firstPrintOut);
            ////    //A++;
            ////}
            //while (A<=200)
            //{
            //    string firstPrintOut = A % 2 == 0 ? "-" : "*";
            //    Console.WriteLine(firstPrintOut);
            //    A++;
            //}
            //3.
            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.WriteLine(j);
            //    }
            //}
            ////5.
            //Console.WriteLine("Enter a number:");
            //int input = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= input; i++)
            //{
            //    Console.WriteLine(input);
            //}
            //Numbers Revisited
            //var stringArray = new Dictionary<int, string>() { {1, "one"}, {2,"two"}, {3, "three" }, {4,"four" }, {5,"five"}, {6,"six" }, {7,"seven" }, {8,"eight" }, {9,"nine" }, {10,"ten" }, {11,"eleven" },
            // { 12, "twelve" }, {13,"thirteen" }, {14,"fourteen" }, {15,"fifteen" }, {16,"sixteen"}, { 17,"seventeen"}, {18,"eighteen" }, {19,"nineteen" }, {20,"twenty" },
            // {30,"thirty" }, {40,"fourty" }, {50,"fifty" }, {60,"sixty"}, {70,"seventy" }, {80,"eighty"}, {90,"ninety"}, {100,"one hundred" } };
            //for (int E = 1; E < 101; E++)
            //{
            //    if (stringArray.ContainsKey(E))
            //    {
            //        Console.WriteLine(stringArray[E]);
            //    }
            //    else
            //    {
            //        // char values are stores as their ascii code number
            //        string numberAsString = Convert.ToString(E);
            //        string units = Convert.ToString(E)[1] + "";
            //        string tens = numberAsString[0] + "0";
            //        Console.WriteLine($"{stringArray[int.Parse(tens)]} {stringArray[Convert.ToInt32(units)]}");
            //    }
            //}
            //string[] digits = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //string[] teens = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            //string[] tens = { "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            //foreach (string digit in digits)
            //{
            //    Console.Write(digit + ", ");
            //}
            //Console.Write("\n");

            //foreach (string teen in teens)
            //{
            //    Console.Write(teen + ", ");
            //}
            //Console.Write("\n");

            //foreach (string ten in tens)
            //{
            //    foreach (string digit in digits)
            //    {
            //        Console.Write(ten + " " + digit + ", ");
            //    }
            //    Console.Write("\n");
            //}
            //Console.Write("one hundred");
            //Console.WriteLine("Cash amount:");
            //float cashAmount = float.Parse(Console.ReadLine());
            //Console.WriteLine("Cost of purchase:");
            //float purchaseAmount = float.Parse(Console.ReadLine());
            //var change = cashAmount - purchaseAmount;
            //change_maker(change);
            //PrintVerticalReverse("Today is a good day.");
            Console.WriteLine(DoesInputContain("Today is a good day.", "good"));
        }
        static int GetWordCount(string input)
        {
            var splittedInput = input.Split(' ');
            return splittedInput.Length;
        }
        static void PrintVertical(string input)
        {
            var splittedInput = input.Split(' ');
            foreach (var word in splittedInput)
            {
                Console.WriteLine(word);
            }
        }
        static void PrintVerticalReverse(string input)
        {
            var splittedInput = input.Split(' ');
            for (int i = splittedInput.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(splittedInput[i]);
            }
        }
        static bool DoesInputContain(string input, string textToFind)
        {
            return input.Contains(textToFind);
        }
        //static void change_maker(float cost)
        //{
        //    float[] denominations = { 50F, 20F, 10F, 5F, 2F, 1F, 0.5F, 0.2F, 0.1F, 0.05f, 0.02F, 0.01F };
        //    List<float> change = new List<float>();
        //    float running = cost;
        //    foreach (float denomination in denominations)
        //    {
        //        float n = (running / denomination >= 1) ? MathF.Floor(running / denomination) : 0F;
        //        for (int i = 0; i < (int)n; i++)
        //            change.Add(denomination);
        //        running -= denomination * n;
        //    }
        //    foreach (float coin in change)
        //    {
        //        Console.WriteLine(coin);
        //    }
        //}
    }
}
