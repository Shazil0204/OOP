using Breeding_station.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breeding_station.Model.Class
{
    internal class Dog : Animal, ISound
    {
        #region Constructor
        public Dog(string type, string sex, string reproduction, int legs, string fur, int age, bool available, string sound)
            :base(type, sex, reproduction, legs, fur, age, available, sound)
        {

        }
        #endregion

        public override bool IsAvailable()
        {
            _available = true;
            return _available;
        }

        public override string MakeSound()
        {
            return _sound;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
