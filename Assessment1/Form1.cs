using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;

namespace Assessment1
{
    public partial class Form1 : Form
    {
        private LoginController loginController = new LoginController();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_username_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            loginController.UserName = textBox_username.Text;
            loginController.Password = textBox_password.Text;

            errorProvider.Clear();

            int isValid = loginController.LoginValidation();

            switch(isValid)
            {
                case 1:
                    errorProvider.SetError(textBox_username, "Username is required");
                    return;
                case 2:
                    errorProvider.SetError(textBox_password, "Password is required");
                    return;
                default:
                    break;
            }

            
            
        }
    }
}
