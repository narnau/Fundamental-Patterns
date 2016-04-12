using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental_Patterns.Builder
{
    public class MainBuilderProgram
    {
        private UserGenerator userGenerator;
        private UserBuilder lowSecurityUserBuilder;
        private UserBuilder highSecurityUserBuilder;

        public MainBuilderProgram()
        {
            this.userGenerator = new UserGenerator();
            this.lowSecurityUserBuilder = new LowSecurityUserBuilder();
            this.highSecurityUserBuilder = new HighSecurityUserBuilder();
        }

        public void Run()
        {
            Console.WriteLine("Builder pattern example:");
            Console.WriteLine();
            // Generate a user with a low security password
            this.userGenerator.setUserBuilder(this.lowSecurityUserBuilder);
            this.userGenerator.CreateUser("John");
            User john = this.userGenerator.GetUser();
            Console.WriteLine("John password: {0}", john.Password);
            // Generate a user with a high security password
            this.userGenerator.setUserBuilder(this.highSecurityUserBuilder);
            this.userGenerator.CreateUser("Hanna");
            User hanna = this.userGenerator.GetUser();
            Console.WriteLine("Hanna password: {0}", hanna.Password);
            Console.WriteLine();
        }
    }
}
