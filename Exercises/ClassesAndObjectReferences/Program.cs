using System;
using System.Collections; 


namespace ClassesAndObjectReferences
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Book book1 = new Book("Harry Potter: Prisoner of Askaban", "2003", true, "Fantasy");
            Book book2 = new Book("1984", "1960", true, "Fantasy");
            Book book3 = new Book("The shining", "1980", true, "Horror");
            Book book4 = new Book("A series of unfortunate events", "1990", true, "Childrens");
            Book book5 = new Book("The tiger who came to tea", "1800", true, "Childrens");

            Book book6 = new Book("The walking dead", "Bill", "2000"); 

            ArrayList myBookList = new ArrayList { book2, book3, book4};
            myBookList.Add(book1);

            //foreach (Book books in myBookList)
            //{
              //  Console.WriteLine(books.GetInformation());
            //}
            // Console.WriteLine(book1.GetInformation()); 

            Library library = new Library("National Library", "123 fake street", myBookList);

            library.Add(book5);

            library.ReadAll(); 
        }
    }

    class Book
    {
        public Book(string title, string publishDate, bool fiction, string genre)
        {
            this.Title = title;
            this.PublishDate = publishDate;
            this.Fiction = fiction;
            this.Genre = genre; 
        }

        public Book(string title, string author, string publishDate)
        {
            this.Title = title;
            this.Author = author;
            this.PublishDate = publishDate; 
        }

        /// <summary>
        /// Overriding the ToString method. 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Title}, {PublishDate}, {Fiction}, {Genre}";
        }

        public string Title { get; set; }

        public string PublishDate { get; set; }
        public bool Fiction { get; set; }
        public string Genre { get; set; }

        public string Author { get; set; }
        public string GetInformation()
        {
            return $"{Title}, {PublishDate}, {Fiction}, {Genre}";
        }
    }

    class Library
    {
        public Library(string name, string address, ArrayList bookList)
        {
            this.BookList = bookList;

            this.Name = name;
            this.Address = address;
        }

        public string Name { get; set; }
        public string Address { get; set; }

        ArrayList BookList = new ArrayList { };

        public void Add(Book book)
        {
            BookList.Add(book);
        }

        public void Remove(Book book)
        {
            BookList.Remove(book);
        }

        public void ReadAll()
        {
            foreach (Book b in BookList)
            {
                Console.WriteLine(b.GetInformation());
            }
            
        }
    }
}
