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

        readonly LoginLogic loginLogic = new LoginLogic();

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }

        public LoginController() {
            
            loginLogic.Login(UserName, Password);

        }

        public int LoginValidation() {
            
            if (string.IsNullOrWhiteSpace(UserName))
            {
                return 1;
            }

            if (string.IsNullOrWhiteSpace(Password))
            {
                return 2;
            }

            return 0;
        }
        

      
    }
}
