using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedQuestions
{
    internal class Book
    {
            public string ISBN { get; set; }
            public string Title { get; set; }
            public string[] Authors { get; set; }
            public DateTime PublicationDate { get; set; }
            public decimal Price { get; set; }
            public Book(string _ISBN, string _Title,
            string[] _Authors, DateTime _PublicationDate,
            decimal _Price)
            {
               this.ISBN = ISBN;
             this. Title = _Title;
             this. Authors = _Authors;
             this. PublicationDate = _PublicationDate;
             this. Price = _Price;

        }
            public override string ToString()
            {
            return $" bookIsbn {ISBN} , BookTiTle {Title},Authors {Authors},PublicanTime{PublicationDate.ToShortDateString},Price{Price},";
            }
        }
    }
