using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BookLogic
    {
        private string bookName;
        int bookID;
        string author;
        string category;
        string language;
        int publishYear;
      
        public DataSetBook.ViewBookDataTable bookExists;
        public string BookName { get => bookName; set => bookName = value; }
        public int BookID { get => bookID; set => bookID = value; }
        public string Author { get => author; set => author = value; }
        public string Category { get => category; set => category = value; }
        public string Language { get => language; set => language = value; }
        public int PublishYear { get => publishYear; set => publishYear = value; }

        public void GetBookByName(string bookName) { 
            BookDAO bookDAO = new BookDAO();
            bookDAO.GetAuthor(bookName);
        }

        public bool BookExists(string bookName) {

            bookExists = new BookDAO().GetBookByName(bookName);

            return bookExists.Rows.Count > 0;
                
        }

        public List<Books> SearchBooks(string keyword, string author)
        {
            BookDAO dao = new BookDAO();
            return dao.SearchBooks(keyword, author);
        }
    }
}
