using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class BookController
    {
        private string bookName;

        private readonly BookLogic bookLogic = new BookLogic();

        public string BookName { get => bookName; set => bookName = value; }

        public BookController() { 
            bookLogic.BookName = bookName;
        }

        public bool GetBook(string bookName) { 
            bookLogic.GetAuthor(bookName);
            return true;
        }

        public bool BookExists(string bookName) { 
            return bookLogic.BookExists(bookName);
        }

    }
}
