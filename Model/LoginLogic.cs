using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal class LoginLogic
    {
        public void Login(string userName) { 
            LoginDAO loginDAO = new LoginDAO();
            loginDAO.GetUser(userName);
        }
    }
}
