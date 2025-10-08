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
        private int userLevel;


        private readonly LoginLogic loginLogic = new LoginLogic();

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public int UserLevel { get => userLevel; set => userLevel = value; }

        public LoginController() {
            loginLogic.UserName = userName;
            loginLogic.Password = password;
            UserLevel = loginLogic.UserLevel;
        }

        public bool IsValid(string username, string password) {
            return loginLogic.IsValid(username, password);
        }

        public int GetUserLevel(string username, string password) {
            var levelString = loginLogic.GetUserLevel(username, password);
            if (int.TryParse(levelString, out int level)) {
                UserLevel = level;
                return level;
            }
            return -1; // or some default/error value
        }

    }
}
