using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Inheritance.Model
{
    internal class ProjectManager: Manager
    {
        protected string email;

        public ProjectManager(string FirstName, string LastName, string CPR, int PhoneNumber, string Email): base(FirstName, LastName, CPR, PhoneNumber)
        {
            email = Email;
        }

        public override string ToString()
        {
            return $"{base.ToString()},\nEmail: {email}";
        }
    }
}
