namespace StaticStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            //Library.AddBook(new Book { Title = "Nice book", Author = "James Mann" });
            //Library.GetBooks();
            //Library.Name = "James Roger's Library";

            //will run static and default
            Library library = new Library();

            //will only run defualt
            Library newLibrary = new Library();
            Library oterNewLibrary = new Library();
        }
    }
}
