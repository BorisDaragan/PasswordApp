using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA.Model
{
    public class User
    {
        public string Login { get; set; }
        public Password Password { get; set; }

        public User(string login, Password password)
        {
            Login = login;
            Password = password;
        }
    }
}
