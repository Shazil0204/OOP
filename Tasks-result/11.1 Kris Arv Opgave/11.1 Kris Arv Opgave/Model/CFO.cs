using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._1_Kris_Arv_Opgave.Model
{
    internal class CFO: CEO
    {
        #region Fields
        // This field will only be used in this scope
        private string _financialExpertise;
        #endregion

        #region Constructor
        /// <summary>
        /// This constructor will be used in all the classes that inherit from Employee class
        /// </summary>
        /// <param name="JobTitle"></param>
        /// <param name="FirstName"></param>
        /// <param name="LastName"></param>
        /// <param name="Salary"></param>
        protected CFO(string JobTitle, string FirstName, string LastName, ushort Salary) 
            :base(JobTitle, FirstName, LastName, Salary)
        {

        }

        /// <summary>
        /// This is CFO's personal constructor
        /// </summary>
        /// <param name="JobTitle"></param>
        /// <param name="FirstName"></param>
        /// <param name="LastName"></param>
        /// <param name="Salary"></param>
        /// <param name="FinancialExpertise"></param>
        internal CFO(string JobTitle, string FirstName, string LastName, ushort Salary, string FinancialExpertise) 
            :this(JobTitle, FirstName, LastName, Salary)
        {
            _financialExpertise = FinancialExpertise;
        }
        #endregion

        #region Testing Program!
        /// <summary>
        /// This is just to test program!
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{base.ToString()}\nFinancial Expertise {_financialExpertise}\n";
        }
        #endregion
    }
}
