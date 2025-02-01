using System.Diagnostics;

namespace AdvancedQuestions
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            List<Book> books = new List<Book>()
            {
                new Book("9102830", "Titanic", new string[] { "Mira", "Dina" }, new DateTime(2024, 12, 3), 9000),
                new Book("9102831", "Power of now ", new string[] { "Anony hopkins" }, new DateTime(1925, 4, 10), 1200),
                new Book("9102832", "Talent is overrated", new string[] { "IOk" }, new DateTime(1949, 6, 8), 1500)
            };


            //Func<Book, string> getISBN = delegate (Book B) { return B.ISBN; };
            Func<Book, string> getTitle = book => $"Book Title: {book.Title}";
            // LibraryEngine.ProcessBooks(books, getISBN);
            LibraryEngine.ProcessBooks(books, getTitle);


        }
    }
}
        