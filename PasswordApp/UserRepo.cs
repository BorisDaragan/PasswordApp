using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PA.BO;

namespace PA.DAL
{
    public class UserRepo
    {
        private static ConcurrentDictionary<User, Password> users;

        static UserRepo()
        {
            users = new ConcurrentDictionary<User, Password>();
        }

        public void SaveOrUpdatePassword(User user, Password password)
        {
            users.AddOrUpdate(user, password, (key, existingPassword) =>
                {
                    // If this delegate is invoked, then the key already exists.
                    existingPassword  = password;
                    return existingPassword;
                });
        }

        public Password GetPassword(User user)
        {
            Password password = new Password();
            bool exist = users.TryGetValue(user, out password);

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
