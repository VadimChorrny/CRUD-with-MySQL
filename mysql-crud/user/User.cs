using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mysql_crud.user
{
    [Serializable]
    class User
    {
        public string Login; // email
        public string Password;
        public User(string login, string pass)
        {
            Login = login;
            Password = pass;
        }
    }
}
