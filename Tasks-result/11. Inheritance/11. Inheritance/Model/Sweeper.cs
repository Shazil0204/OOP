using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Inheritance.Model
{
    internal class Sweeper: Employee
    {
        public Sweeper(string FirstName, string LastName, string CPR) :base(FirstName, LastName, CPR)
        {

        }

        public override string ToString()
        {
            return base.ToString(); 
        }
    }
}
