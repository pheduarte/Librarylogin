using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model; // If Book is defined in the Model namespace

namespace Model
{
    public class BookDAO
    {
        private static readonly string connectionString =
    ConfigurationManager.ConnectionStrings["LibraryDb"]?.ConnectionString
    ?? throw new InvalidOperationException("Connection string 'LibraryDb' not found.");

        public DataSetBook.ViewBookDataTable GetAuthor(string bookName)
        { 
            DataSetBookTableAdapters.ViewBookTableAdapter bookAdapter = new DataSetBookTableAdapters.ViewBookTableAdapter();
            DataSetBook.ViewBookDataTable bookTable = bookAdapter.GetAuthor(bookName);
            return bookTable;
        }

        public DataSetBook.ViewBookDataTable GetBookByName(string bookName)
        { 
            DataSetBookTableAdapters.ViewBookTableAdapter bookAdapter = new DataSetBookTableAdapters.ViewBookTableAdapter();
            DataSetBook.ViewBookDataTable bookTable = bookAdapter.GetBook(bookName);
            return bookTable;
        }

        public List<Books> SearchBooks(string keyword, string author)
        {
            List<Books> book = new List<Books>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT * FROM ViewBook
                                 WHERE (BookName LIKE @Keyword OR Category LIKE @Keyword)
                                 AND (Author LIKE @Author OR @Author = '')";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                cmd.Parameters.AddWithValue("@Author", "%" + author + "%");

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Books b = new Books()
                    {
                        //BookID = (int)reader["BookID"],
                        BookName = reader["BookName"].ToString(),
                        Author = reader["Author"].ToString(),
                        Category = reader["Category"].ToString(),
                        Language = reader["Language"].ToString(),
                        PublishYear = (int)reader["PublishYear"]
                    };
                    book.Add(b);
                }
            }

            return book;
        }
    }    
}
