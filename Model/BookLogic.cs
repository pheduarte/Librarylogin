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
        public DataSetBook.ViewBookDataTable bookExists;
        public string BookName { get => bookName; set => bookName = value; }
        public void GetAuthor(string bookName) { 
            BookDAO bookDAO = new BookDAO();
            bookDAO.GetAuthor(bookName);
        }

        public bool BookExists(string bookName) {

            bookExists = new BookDAO().GetAuthor(bookName);

            return bookExists.Rows.Count > 0;
                
        }
    }
}
