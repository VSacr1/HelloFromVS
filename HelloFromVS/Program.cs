using System;
using System.IO;

namespace HelloFromVS
{
    class Program
    {
        static void Main(string[] args)
        {
            //var currentDateAndTime = DateTime.Now;
            //Console.WriteLine(currentDateAndTime.AddDays(5).DayOfWeek);
            Console.WriteLine("Input a date: ");
            var dateInput = Console.ReadLine();
            try
            {
                var convertedDate = DateTime.Parse(dateInput);
                Console.WriteLine(convertedDate);
            }
            catch (Exception e)
            {
                Console.WriteLine("Sorry, your input was in a bad format, please close the app and try again.");
                //Log exception.
                Console.WriteLine($"Technical details: {e.Message}");
            }
            finally
            {
                Console.WriteLine("I will run under any circumstance");
            }
            //Research TryParse

            #region CollapseMain
            //Console.WriteLine("What is your name? ");
            //var name = Console.ReadLine();
            //var date = DateTime.Now;
            //Console.WriteLine($"\nHello, {name}, on {date:d} at {date:t}!");

            //declare
            //int myInt;
            //assigning
            //myInt = 12334568;
            //instantiation
            //long myLong = 123343454534534;
            //float myFloat = 2.2564546F;
            //double myDouble = 12.245645465;
            //bool myBool = true;
            //bool myOtherBool = false;
            //char myChar = 'J';
            //string myString = "a bit longer and contains more character";

            //var myVar = 1232134345;

            //string firstName = "Dara";
            //int age = 256;
            //Console.WriteLine(firstName + " is " + age + " year old.");


            //Console.WriteLine(34 + "+" + 56 + "=" + (34 + 56));

            //Console.WriteLine("Enter username: ");
            //var userName = Console.ReadLine();
            //Console.WriteLine("User name is : " + userName);
            //Console.WriteLine("Enter age: ");
            //int age = Console.ReadLine();
            //int age = Convert.ToInt32(Console.ReadLine());
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Age is " + age);
            //Console.WriteLine(1);
            //Console.WriteLine(2);
            //Console.WriteLine(3);
            //Console.WriteLine(4);
            //Console.WriteLine(5);
            //go to 1000000
            //multiples of 5,10,15,20,.....1000
            //for (int i = 5; i <= 1000; i += 5)
            //{
            //    Console.WriteLine(i);
            //}
            //string[] myClass = { "Ben", "Dara", "Victoria" };
            //foreach (var member in myClass)
            //{
            //    Console.WriteLine(member);
            //}
            //while it's cold, turn on the heater.
            //while it's hot, turn on the fan.
            //Console.WriteLine("While Loop");
            //int i = 100;
            //while (i > 10 && i <= 50)
            //{
            //    Console.WriteLine(i);
            //    i += 5;
            //}
            //Console.WriteLine("Do-While Loop");
            //int j = 100;
            //do
            //{
            //    Console.WriteLine(j);
            //    j += 5;
            //} while (j > 10 && j <= 50);
            //string greeting = "Hello Folks|Hi People|Hi Y'all";
            //Console.WriteLine(greeting);
            //string[] greetingSplitCollection = greeting.Split('|');
            //foreach (var greetingItem in greetingSplitCollection)
            //{
            //    Console.WriteLine(greetingItem);
            //}
            //string greeting = "Hello World, it's a beautiful day.";
            //Console.WriteLine(greeting.Contains("beautiful"));
            //Console.WriteLine(greeting);
            //string replacedGreeting = greeting.Replace("beautiful", "good");
            //Console.WriteLine(greeting.Replace("beautiful", "good"));
            //Console.WriteLine(greeting);
            // This is Dara's Visual Studio
            //Console.WriteLine("This is Dara's Visual Studio");
            //Console.WriteLine("Dara said \"This is Dara's Visual Studio\"");
            //Console.WriteLine('\'');
            //Console.WriteLine("This is a new");
            //Console.WriteLine("line");
            //Console.WriteLine("This is a new\nline");
            //Console.WriteLine("Name\tEmail Address\tPhone Number");
            //Console.WriteLine("Dara\tdoladapo@qa.com\t012345678");
            //Console.WriteLine("Daro\tdooola@qa.com\t012345678");

            //string firstName = "Dara", lastName = "Oladapo";
            //string fullName = firstName + " " + lastName;
            //Console.WriteLine(fullName);
            //Console.WriteLine("{0} {1}", firstName, lastName);
            //Console.WriteLine($"{firstName} {lastName}");

            //string name = "Dara";
            //int firstNumber = 2, secondNumber = 52;
            //Console.WriteLine(name + " " + firstNumber);
            //Console.WriteLine(name + " " + (firstNumber + secondNumber));
            //Console.WriteLine($"{name} {firstNumber + secondNumber}");

            //if a user is 18+
            //comparison in # - <:less than, >: greater than, <=: less than or equal to, >=:greater than or equal to, ==: equal to, !=: not equal to
            // ||: or &&: and

            //var age = int.Parse(Console.ReadLine());
            //if (age <= 18)
            //{
            //    Console.WriteLine("Sorry, not old enough.");
            //}
            //else if (age >= 65)
            //{
            //    Console.WriteLine("Too old to join, you should be retired.");
            //}
            //else if (age < 0 || age > 150)
            //{
            //    Console.WriteLine("Age value is invalid");
            //}
            //else
            //{
            //    Console.WriteLine("Welcome to workforce.");
            //}

            //if (true && true && true) { }
            //if (true)
            //{
            //    if (true)
            //    {
            //        if (true)
            //        {
            //            if (true)
            //            {

            //            }
            //        }
            //    }
            //}

            //grades: A, B, C, D, E, F
            /*
             * A: 70
             * B: 60
             * C: 50
             * D: 45
             * E: 40
             * F: 10
             */
            //int score = int.Parse(Console.ReadLine());
            //switch (score)
            //{
            //    case 70:
            //        Console.WriteLine("A");
            //        break;
            //    case 60:
            //        Console.WriteLine("B");
            //        break;
            //    case 50:
            //        Console.WriteLine("C");
            //        break;
            //    case 45:
            //        Console.WriteLine("D");
            //        break;
            //    case 40:
            //        Console.WriteLine("E");
            //        break;
            //default:
            //    Console.WriteLine("F");
            //    break;

            ////}

            //int addition = 2 + 2;//4
            //double multiplication = 2 * 3.0;//6.0

            //int remainderDiv = 5 % 3;//2

            //double calculation = 2 * 3 + 3 + 4 - 7 * 3 / 2.0 + (3 * 2);
            //Console.WriteLine(calculation);
            //squareroot of 25
            //double sqrt = Math.Sqrt(52);
            //Console.WriteLine(sqrt);

            //area of circle = Pi * r*r
            //double radius = 3.5;
            //double area = Math.PI * radius * radius;

            //Math.Pow(81, 1/3);
            ////string[] cars = { "Ford", "Vauxhaul", "Toyota", "Nissan" };
            ////foreach (var car in cars)
            ////{
            ////    Console.WriteLine(car);
            ////}
            ////string[] otherCars;
            ////otherCars = new string[4];
            ////otherCars[0] = "Mercedez";
            ////otherCars[1] = "Mazda";
            ////otherCars[2] = "Tesla";
            ////otherCars[3] = "Volvo";
            ////Array.Sort(otherCars);
            ////foreach (var car in otherCars)
            ////{
            ////    Console.WriteLine(car);
            ////}
            ////otherCars = new string[5];
            ////otherCars[4] = "Skoda";
            ////Console.WriteLine(otherCars[0]);

            //int[] myNumbers = { 5, 1, 8, 9 };
            ////non-helped way - bubble sorting.
            //int maxValue = myNumbers.Max();
            //Console.WriteLine(maxValue);
            //int minValue = myNumbers.Min();
            //Console.WriteLine(minValue);
            //int sumValue = myNumbers.Sum();
            //Console.WriteLine(sumValue);
            //int a = 5, b = 4, c = a + b;
            //int d = 7, e = 65, f = d + e;
            //methods

            //int a = 2, b = 4;
            //int c = Add(a, b);
            //Console.WriteLine($"{a}+{b}={c}");
            //int d = Subtract(a, b);
            //Console.WriteLine($"{a}-{b}={d}");

            //double e = 7.8, f = 2.1;
            //double g = Subtract(e, f);
            //Console.WriteLine($"{e}-{f}={g}");
            //int inputValue = 6;
            ////var increasedValue=Increase(inputValue);
            ////Console.WriteLine(increasedValue);
            //Console.WriteLine(inputValue);
            //Increase(ref inputValue);
            //Console.WriteLine(inputValue);

            //string exWrite = "\nIt is a good day. Nice and Easy";
            //File.WriteAllText(@"C:\Dev\hello.txt", exWrite);
            //File.AppendAllText(@"C:\Dev\hello.txt", exWrite);

            //string readText = File.ReadAllText(@"C:\Dev\hello.txt");
            //System.Console.WriteLine(readText);

            //string OriginalFile = @"C:\Dev\test.txt";
            //string FileToReplace = @"C:\Dev\test2.txt";
            //string BackUpOfFileToReplace = @"C:\Dev\test2.txt.bac";

            //Console.WriteLine("Move the contents of " + OriginalFile + " into " + FileToReplace + ", delete " + OriginalFile +
            //                   ", and create a backup of " + FileToReplace + ".");

            // Replace the file.
            //ReplaceFile(OriginalFile, FileToReplace, BackUpOfFileToReplace);

            //Console.WriteLine("Done");
            #endregion
        }

        #region Collapse
        //public static void ReplaceFile(string FileToMoveAndDelete, string FileToReplace, string BackupOfFileToReplace)
        //{
        //    File.Replace(FileToMoveAndDelete, FileToReplace, BackupOfFileToReplace, false);
        //}
        //static int Increase(int inputValue)
        //{
        //    var addedValue = inputValue+=1;
        //    return addedValue;
        //}
        //static void Increase(ref int inputValue)
        //{
        //    inputValue += 1;
        //}
        static int Add(int firstValue, int secondValue)
        {
            var addition = firstValue + secondValue;
            return addition;
        }
        static int Subtract(int firstValue, int secondValue)
        {
            var subtraction = firstValue - secondValue;
            return Math.Abs(subtraction);
        }
        static double Subtract(double firstValue, double secondValue)
        {
            var subtraction = firstValue - secondValue;
            return Math.Abs(subtraction);
        }
        static double Subtract(double firstValue, int secondValue)
        {
            var subtraction = firstValue - secondValue;
            return Math.Abs(subtraction);
        }
        static double Subtract(int firstValue, double secondValue)
        {
            var subtraction = firstValue - secondValue;
            return Math.Abs(subtraction);
        }
        #endregion
    }
}
