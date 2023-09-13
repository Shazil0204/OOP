using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Planet.Model
{
    internal class Lists
    {
        #region List
        /// <summary>
        /// List for all the planets
        /// </summary>
        public List<Planet> planets = new List<Planet>();

        /// <summary>
        /// List for planets with mean temperature under 0
        /// </summary>
        public List<Planet> planetsMeanTemperature = new List<Planet>();

        /// <summary>
        /// List for planets with diiameter between 10000 and 50000 km
        /// </summary>
        public List<Planet> planetsDiameter = new List<Planet>();

        #endregion
    }
}
