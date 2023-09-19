using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace _11.Inheritance.Model
{
    internal class Employee
    {
        private protected string firstName;
        private protected string lastName;
        private protected string cpr;

        protected Employee(string FirstName, string LastName, string CPR)
        {
            firstName = FirstName;
            lastName = LastName;
            cpr = CPR;
        }

        public override string ToString()
        {
            return 
                $"First Name {firstName},\n" +
                $"Last Name {lastName},\n" +
                $"CPR {cpr}";
        }

    }
}
