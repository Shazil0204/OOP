using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _11._1_Kris_Arv_Opgave.Model
{
    internal class CEO: Employee
    {
        #region Fields
        // This field will only be used in this scope
        private string _strategicVision;
        #endregion

        #region constructor
        /// <summary>
        /// This constructor will be used in all the classes that inherit from Employee class
        /// </summary>
        /// <param name="JobTitle"></param>
        /// <param name="FirstName"></param>
        /// <param name="LastName"></param>
        /// <param name="Salary"></param>
        protected CEO(string JobTitle, string FirstName, string LastName, ushort Salary) 
            :base(JobTitle, FirstName, LastName, Salary)
        {
            
        }

        /// <summary>
        /// This is CEO's personal constructor
        /// </summary>
        /// <param name="JobTitle"></param>
        /// <param name="FirstName"></param>
        /// <param name="LastName"></param>
        /// <param name="Salary"></param>
        /// <param name="StrategicVision"></param>
        internal CEO(string JobTitle, string FirstName, string LastName, ushort Salary, string StrategicVision) 
            :this(JobTitle, FirstName, LastName, Salary)
        {
            _strategicVision = StrategicVision;
        }
        #endregion

        #region Testing Program!
        /// <summary>
        /// This is just to test program!
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{base.ToString()}\nStrategic Vision: {_strategicVision}\n";
        }
        #endregion
    }
}
