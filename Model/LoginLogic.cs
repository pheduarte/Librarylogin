using Model.DataSet1TableAdapters;
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
        public DataSet1.TabUserDataTable userExists;

        public LoginLogic() { 

            
        }

        public bool IsValid(string username, string password)
        {
            userExists = loginDAO.Login(username, password);

            return userExists.Rows.Count > 0;
        }

        public string GetUserLevel(string username, string password)
        {
            userExists = loginDAO.Login(username, password);

            if (userExists.Rows.Count > 0)
            {
                var user = userExists[0];
                return user.UserLevel.ToString();
            }
            return null;
        }
    }
}
