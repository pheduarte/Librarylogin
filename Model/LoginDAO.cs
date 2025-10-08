using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model
{
    internal class LoginDAO
    {

        public LoginDAO() {
        }

        public DataSet1.TabUserDataTable Login(string username, string password) {
            DataSet1TableAdapters.TabUserTableAdapter userAdapter = new DataSet1TableAdapters.TabUserTableAdapter();

            DataSet1.TabUserDataTable userTable = userAdapter.Login(username, password);

            return userTable;
        }
    }
}
