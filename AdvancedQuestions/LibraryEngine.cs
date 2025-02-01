using AdvancedQuestions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedQuestions
{
    delegate string BookFunctionDelegate(Book book);
    internal class LibraryEngine
    {
        public static void ProcessBooks(List<Book> bList, Func<Book, string> fPtr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }
    }
}



