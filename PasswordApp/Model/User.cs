
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
