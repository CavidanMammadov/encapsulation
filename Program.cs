namespace Encapsulation.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Libary libary = new Libary();
            Book book = new Book("dram", 1, 29 ,"orucelinin drami");
            Book book1 = new Book("dram",2, 13,"cavidanin drami");
            Book book2 = new Book("love", 3 , 199, "Mellimlere olan sevgi");
            Book book3 = new Book("love", 4, 122,"qadinlara olan sevgi");
            libary.AddBook(book);
            libary.AddBook(book1);
                libary.AddBook(book2);
            libary.AddBook(book3);
            Book[] filteredBooks = libary.GetFilteredBooks(100,200);
             foreach(var item in filteredBooks)
            {
                item.ShowFullInfo();
            }

        }
    }
}
