using System;

namespace Stringy
{
    class Program
    {
        static void Main(string[] args)
        {
            //string petList = "Fox,Cat,Dog,Rabbit,Duck,Parrot";
            ////string[] petArray = petList.Split(',');
            ////Console.WriteLine(petArray[3]);
            //Console.WriteLine(petList.Contains("Dog"));
            string username = Console.ReadLine();
            string[] options = { "Play", "Options", "Sign In", "Exit Game" };
            Console.WriteLine($"Welcome to the Text Adventure Game!\nname: [{username}]\n\nMenu:\n\t1.) {options[0]}\n\t2.) {options[1]}\n\t3.) {options[2]}\n\t4.) {options[3]}");
        }
    }
}
