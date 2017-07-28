
using PA.Model;

namespace PA.BLL
{
    public class UserBL
    {
        public string Login { get; set; }
        private PasswordBL _password;
        public Password Password { get; set; }

        public UserBL()
        {
            
        }

        public UserBL(string login, Password password)
        {
            this.Login  = login;
            this.Password = password;
        }
        
        
        public bool CheckPassword(Password password)
        {
            if( this.Password == password)
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
