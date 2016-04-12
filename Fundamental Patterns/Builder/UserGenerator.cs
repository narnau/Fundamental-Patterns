using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental_Patterns.Builder
{
    public class UserGenerator
    {
        private UserBuilder userBuilder;

        public void setUserBuilder(UserBuilder userBuilder)
        {
            this.userBuilder = userBuilder;
        }

        public User GetUser()
        {
            return this.userBuilder.GetUser();
        }

        public void CreateUser(string userName)
        {
            this.userBuilder.CreateNewUser(userName);
            this.userBuilder.GeneratePassword();
        }
    }
}
