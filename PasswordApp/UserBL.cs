using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PA.BO;
using PA.DAL;

namespace PA.BLL
{
    public class UserBL
    {
        private User user;
        private Password password;
        private static UserRepo userRepo;

        public UserBL(string login, PasswordBL password)
        {
            this.user  = new User(login);
            this.password = new Password(password.PasswordParts);
        }

        static UserBL()
        {
            userRepo = new UserRepo();
        }

        public void SaveOrUpdate()
        {
            userRepo.SaveOrUpdatePassword(user, password);
        }
    }
}
