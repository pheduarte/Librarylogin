using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class LoginLogic
    {
        private string userName;
        private string password;
        private int userLevel;

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public int UserLevel { get => userLevel; set => userLevel = value; }

        private readonly LoginDAO loginDAO = new LoginDAO();

        public LoginLogic() { }
        public DataSet1.TabUserDataTable userExists;
        public bool IsValid(string username, string password)
        {
            userExists = loginDAO.Login(username, password);

            if (userExists.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
