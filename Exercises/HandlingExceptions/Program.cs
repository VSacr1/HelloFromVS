using System;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            ExceptionMethod(); 
        }

        public static void ExceptionMethod()
        {
            try
            {
                throw new Exception("Generic Exception!");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message); 
            }
            Console.WriteLine("Hello World"); 
        }
    }
}
