using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._1_Kris_Arv_Opgave.Model
{
    internal class Employee
    {
        #region Fields
        protected string firstName;
        protected string lastName;
        protected string jobTitle;
        protected ushort salary;
        private ushort _bonus; // This field will only be used in this scope
        #endregion

        #region Constructors
        /// <summary>
        /// This constructor will be used in all the classes that inherit from Employee class
        /// </summary>
        /// <param name="JobTitle"></param>
        /// <param name="FirstName"></param>
        /// <param name="LastName"></param>
        /// <param name="Salary"></param>
        protected Employee(string JobTitle, string FirstName, string LastName, ushort Salary)
        {
            firstName = FirstName;
            lastName = LastName;
            jobTitle = JobTitle;
            salary = Salary;
        }

        /// <summary>
        /// This is Employee's personal constructor
        /// </summary>
        /// <param name="JobTitle"></param>
        /// <param name="FirstName"></param>
        /// <param name="LastName"></param>
        /// <param name="Salary"></param>
        /// <param name="Bonus"></param>
        internal Employee(string JobTitle, string FirstName, string LastName, ushort Salary, ushort Bonus)
            :this(JobTitle, FirstName, LastName, Salary)
        {
            _bonus = Bonus;
        }
        #endregion

        #region Testing Program!
        /// <summary>
        /// This is just to test program!
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return  $"Job Title: {jobTitle}\nName: {firstName} {lastName }\nSalary {salary}\nBonus: {_bonus}";
        }
        #endregion
    }
}
