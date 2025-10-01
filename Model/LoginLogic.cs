using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class LoginLogic
    {
        private readonly LoginDAO loginDAO = new LoginDAO();
        public LoginLogic() { }
        public bool Login(string userName, string password) { 
            
            var storedPassword = loginDAO.GetUserPassword(userName);
            if (storedPassword == null) return false;
            
            return storedPassword == password;
        }
    }
}
