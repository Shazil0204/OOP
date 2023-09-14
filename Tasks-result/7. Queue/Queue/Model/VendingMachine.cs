using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Model
{
    internal class VendingMachine
    {
        #region Variables
        private string drink;
        private string brand;
        #endregion

        #region Properties
        public string Drink { get { return drink; } set {  drink = value; } }
        public string Brand { get {  return brand; } set {  brand = value; } }
        #endregion

    }
}
