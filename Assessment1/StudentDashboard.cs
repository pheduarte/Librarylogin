using Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Windows.Forms;


namespace Assessment1
{
    public partial class StudentDashboard : Form
    {
        BookController bookController = new BookController();

        public StudentDashboard()
        {
            InitializeComponent();
        }

        private void StudentDashboard_Load(object sender, EventArgs e)
        {
            //LoadBooks(); // Load all books when form opens
        }


        private void LoadBooks()
        {
            string keyword = textBoxKeyword.Text.Trim();
            string author = textBoxAuthor.Text.Trim();

            List<Books> book = bookController.SearchBooks(keyword, author);
            dataGridViewBooks.DataSource = null;
            dataGridViewBooks.DataSource = book;

            // Optional: Hide unnecessary columns
            if (dataGridViewBooks.Columns["BookID"] != null)
                dataGridViewBooks.Columns["BookID"].Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void btnExplorer_Click(object sender, EventArgs e)
        {
            LoadBooks();
        }
    }
}
