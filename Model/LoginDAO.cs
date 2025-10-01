using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal class LoginDAO
    {
        private static readonly Dictionary<string, string> Users = new Dictionary<string, string>()
        {
            { "admin", "1234" },
            { "phelippe", "@Metz1603"},
            { "user", "password" }
        };
        //public string GetUser(string userName) {
        //    //connect to the database and get the user

        //    return userName; //temporary just to make GetUser return a string
        //}

        public string GetUserPassword(string userName)
        {
            if (Users.TryGetValue(userName, out string password))
            {
                return password;
            }
            return null;
        }
    }
}
