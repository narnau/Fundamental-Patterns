using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;

namespace Fundamental_Patterns.Builder
{
    public class LowSecurityUserBuilder : UserBuilder
    {
        public override void GeneratePassword()
        {
            // Generate a new 3-character password with 0 non-alphanumeric character.
            this.user.Password = Membership.GeneratePassword(3, 0);
        }
    }
}
