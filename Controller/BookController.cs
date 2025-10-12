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
        int bookID;
        string author;
        string category;
        string language;
        int publishYear;

        private readonly BookLogic bookLogic = new BookLogic();

        public string BookName { get => bookName; set => bookName = value; }
        public int BookID { get => bookID; set => bookID = value; }
        public string Author { get => author; set => author = value; }
        public string Category { get => category; set => category = value; }
        public string Language { get => language; set => language = value; }
        public int PublishYear { get => publishYear; set => publishYear = value; }

        public BookController() { 
            bookLogic.BookName = bookName;
        }

        public bool GetBook(string bookName) { 
            bookLogic.GetBookByName(bookName);
            return true;
        }

        public bool BookExists(string bookName) { 
            return bookLogic.BookExists(bookName);
        }

        public List<Books> SearchBooks(string keyword, string author)
        {
            
            return bookLogic.SearchBooks(keyword, author);
        }

    }
}
