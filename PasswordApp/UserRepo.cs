using System.Collections.Concurrent;
using PA.Model;

namespace PA.DAL
{
    public class UserRepo
    {
        private static ConcurrentDictionary<string, Password> users;

        static UserRepo()
        {
            users = new ConcurrentDictionary<string, Password>();
        }

        public void SaveOrUpdatePassword(User user )
        {
            users.AddOrUpdate(user.Login, user.Password, (key, existingPassword) =>
                {
                    existingPassword  = user.Password;
                    return existingPassword;
                });
        }

        public Password GetPassword(string login)
        {
            Password password = new Password();
            bool exist = users.TryGetValue(login, out password);

            if (exist)
            {
                return password;
            }
            else
            {
                return null;
            }
        }

    }
}
