using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._1_Kris_Arv_Opgave.Model
{
    internal class COO_Manager: COO
    {
        #region Fields
        // This field will only be used in this scope
        private string _authority;
        #endregion

        #region Constructor
        /// <summary>
        /// This constructor will be used in all the classes that inherit from Employee class
        /// </summary>
        /// <param name="JobTitle"></param>
        /// <param name="FirstName"></param>
        /// <param name="LastName"></param>
        /// <param name="Salary"></param>
        protected COO_Manager(string JobTitle, string FirstName, string LastName, ushort Salary) 
            :base(JobTitle, FirstName, LastName, Salary)
        {

        }

        /// <summary>
        /// This is COO_Manager's personal constructor
        /// </summary>
        /// <param name="JobTitle"></param>
        /// <param name="FirstName"></param>
        /// <param name="LastName"></param>
        /// <param name="Salary"></param>
        /// <param name="Authority"></param>
        internal COO_Manager(string JobTitle, string FirstName, string LastName, ushort Salary, string Authority) 
            :this(JobTitle, FirstName, LastName, Salary)
        {
            _authority = Authority;
        }
        #endregion

        #region Testing Program!
        /// <summary>
        /// This is just to test program!
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{base.ToString()}\nAuthority: {_authority}\n";
        }
        #endregion
    }
}
