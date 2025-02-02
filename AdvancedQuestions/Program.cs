using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using static System.Reflection.Metadata.BlobBuilder;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AdvancedQuestions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Book> blist = new List<Book>()
            {
                new Book("78654","Titanic",new string[]{"mira","dina"},new DateTime(2024-03-16),65445),
                new Book("77654","PowerOfNw",new string[]{"Antony hopkins"},new DateTime(2024-03-16),64999),
                new Book("790854","TALENT IS OVERRATED",new string[]{"IOK"},new DateTime(2024-03-16),1044),

            };
            
            //LibraryEngine.ProcessBooks(blist, BookFunctions.GetTitle);
            //LibraryEngine.ProcessBooks(blist, BookFunctions.GetPrice);
            //LibraryEngine.ProcessBooks(blist, BookFunctions.GetAuthors);
  
            // a. User Defined Delegate
            BookDelegate titleDelegate = new BookDelegate(BookFunctions.GetTitle);
            LibraryEngine.ProcessBooks(blist, titleDelegate);

            // b. BCL Delegates (Using Func<Book, string>)
            Func<Book, string> authorDelegate = BookFunctions.GetAuthors;
            LibraryEngine.ProcessBooks(blist, authorDelegate);


            // c. AnonymousMethod
            BookDelegate isbnDelegate = delegate (Book B)
            {
                return B.ISBN;
            };
            LibraryEngine.ProcessBooks(blist, isbnDelegate);

            // d. LambdaExpression
            Func<Book, string> pubDateDelegate = B => B.PublicationDate.ToString(); 
            LibraryEngine.ProcessBooks(blist, pubDateDelegate);
        }
    }
}
        