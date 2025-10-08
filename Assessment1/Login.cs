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

            var userLevel = loginController.GetUserLevel(loginController.UserName, loginController.Password);

            if (loginController.IsValid(loginController.UserName, loginController.Password))
            {
                MessageBox.Show("Login successful");
                this.Hide();
                
                if (userLevel == 1)
                {
                    StudentDashboard studentDashBoard = new StudentDashboard();
                    studentDashBoard.ShowDialog();
                    this.Close();
                    return;
               
                } else { 
                    
                    StaffDashboard adminDashboard = new StaffDashboard();
                    adminDashboard.ShowDialog();
                    this.Close();
                    return;
                }                
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }
    }
}
