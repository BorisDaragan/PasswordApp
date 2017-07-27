
using PA.Model;
using PA.DAL;

namespace PA.BLL
{
    public class UserBL
    {
        public string Login { get; set; }
        private PasswordBL _password;
        private static UserRepo _userRepo;
        public Password Password { get; set; }

        public UserBL()
        {
            
        }

        public UserBL(string login, Password password)
        {
            this.Login  = login;
            this.Password = password;
        }

        static UserBL()
        {
            _userRepo = new UserRepo();
        }

        public void SaveOrUpdate( )
        {
            _userRepo.SaveOrUpdatePassword(new User(this.Login, this.Password));
        }


        internal bool CheckPassword(Password password)
        {
            if (_userRepo.GetPassword(this.Login) == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
