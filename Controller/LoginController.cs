using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
    public class LoginController
    {
        private string userName;
        private string password;

        private readonly LoginLogic loginLogic = new LoginLogic();

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }

        public LoginController() { }

        public bool isLoginSuccessful() {

            if (string.IsNullOrWhiteSpace(UserName)) return false;

            if (string.IsNullOrWhiteSpace(Password)) return false;

            return loginLogic.Login(UserName, Password);
        }
        

      
    }
}
