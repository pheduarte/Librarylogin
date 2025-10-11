using Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            bookController.BookName = textBox1.Text;

            if (bookController.BookExists(bookController.BookName))
            {
                MessageBox.Show("Book found");
            }
            else
            {
                MessageBox.Show("Book not found");
            }
        }
    }
}
