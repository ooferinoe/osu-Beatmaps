using ozuModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ozuDL
{
    public class UserData
    {
        List<User> Account = new List<User>();
        public UserData()
        {
            CreateUserData();
        }

        private void CreateUserData()
        {
            User user1 = new User
            {
                userName = "Atomoz"
            };

            User user2 = new User
            {
                userName = "ooferinoe"
            };

            User user3 = new User
            {
                userName = "Itona"
            };

            Account.Add(user1);
            Account.Add(user2);
            Account.Add(user3);
        }

        public User GetUser(string userName)
        {
            User foundUser = new User();

            foreach (var user in Account)
            {
                if (userName == user.userName)
                {
                    foundUser = user;
                }
            }

            return foundUser;
        }
    }
}
