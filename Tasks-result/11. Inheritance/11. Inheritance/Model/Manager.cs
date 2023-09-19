using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Inheritance.Model
{
    internal class Manager: Employee
    {
        private protected int phoneNumber;

        protected Manager(string FirstName, string LastName, string CPR, int PhoneNumber) :base(FirstName,   LastName,  CPR)
        {
            phoneNumber = PhoneNumber;
        }

        public override string ToString()
        {
            return $"{base.ToString()},\nPhone Number: {phoneNumber}";
        }
    }
}
