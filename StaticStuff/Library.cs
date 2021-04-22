using System;

namespace StaticStuff
{
    class Library
    {
        //public static string Name { get; set; }
        //public static void AddBook(Book book)
        //{
        //    Console.WriteLine($"{book.Title} by {book.Author} added");
        //}
        //public static string GetBooks()
        //{
        //    return "Here are the books";
        //}
        static Library()
        {
            Console.WriteLine("This is a static constructor");
        }
        public Library()
        {
            Console.WriteLine("I am a default constructor");
        }
    }
}
