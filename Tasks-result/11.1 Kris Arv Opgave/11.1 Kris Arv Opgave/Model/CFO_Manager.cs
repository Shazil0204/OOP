using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._1_Kris_Arv_Opgave.Model
{
    internal class CFO_Manager: CFO
    {
        #region Fields
        // This field will only be used in this scope
        private string _oversight;
        #endregion

        #region Constructors
        /// <summary>
        /// This constructor will be used in all the classes that inherit from Employee class
        /// </summary>
        /// <param name="JobTitle"></param>
        /// <param name="FirstName"></param>
        /// <param name="LastName"></param>
        /// <param name="Salary"></param>
        protected CFO_Manager(string JobTitle, string FirstName, string LastName, ushort Salary) 
            :base(JobTitle, FirstName, LastName, Salary)
        {

        }

        /// <summary>
        /// This is CFO_Manager's personal constructor
        /// </summary>
        /// <param name="JobTitle"></param>
        /// <param name="FirstName"></param>
        /// <param name="LastName"></param>
        /// <param name="Salary"></param>
        /// <param name="Oversight"></param>
        internal CFO_Manager(string JobTitle, string FirstName, string LastName, ushort Salary, string Oversight) 
            :this(JobTitle, FirstName, LastName, Salary)
        {
            _oversight = Oversight;
        }
        #endregion

        #region Testing Program!
        /// <summary>
        /// This is just to test program!
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{base.ToString()}\nOversight: {_oversight}\n";
        }
        #endregion
    }
}
