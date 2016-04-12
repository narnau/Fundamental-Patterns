using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental_Patterns.Builder
{
    public abstract class UserBuilder
    {
        protected User user;

        public User GetUser()
        {
            return user;
        }

        public void CreateNewUser(string userName)
        {
            user = new User()
            {
                UserName = userName
            };
        }

        public abstract void GeneratePassword();

    }
}
