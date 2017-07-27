using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PA.Model;
using PA.DAL;

namespace PA.BLL
{
    public class UserService
    {
        public string Login { get; set; }
        private PasswordBL _password;
        private static UserRepo _userRepo;
        public Password Password { get; set; }

        public UserService()
        {
            
        }

        public UserService(string login, PasswordBL password)
        {
            this.Login  = login;
            this._password = password;
        }

        static UserService()
        {
            _userRepo = new UserRepo();
        }

        public void SaveOrUpdate(User user)
        {
            _userRepo.SaveOrUpdatePassword(user);
        }

    }
}
