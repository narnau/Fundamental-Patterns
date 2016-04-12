using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;

namespace Fundamental_Patterns.Builder
{
    public class HighSecurityUserBuilder : UserBuilder
    {
        public override void GeneratePassword()
        {
            // Generate a new 12-character password with 2 non-alphanumeric character.
            this.user.Password = Membership.GeneratePassword(12, 2);
        }
    }
}
