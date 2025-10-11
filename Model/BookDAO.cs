using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BookDAO
    {
        public DataSetBook.ViewBookDataTable GetAuthor(string bookName) { 
            DataSetBookTableAdapters.ViewBookTableAdapter bookAdapter = new DataSetBookTableAdapters.ViewBookTableAdapter();
            DataSetBook.ViewBookDataTable bookTable = bookAdapter.GetAuthor(bookName);
            
            return bookTable;
        }


    }    
}
