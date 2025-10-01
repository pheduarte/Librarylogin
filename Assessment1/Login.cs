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
    public partial class Login : Form
    {
        private LoginController loginController = new LoginController();
        public Login()
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

            if (loginController.isLoginSuccessful()){
                MessageBox.Show("Login successful");
                this.Hide();
                
                Home home = new Home();
                home.ShowDialog();
                this.Close();

            } else {
                errorProvider.SetError(textBox_password, "Invalid username or password");
            }   
            
        }
    }
}
