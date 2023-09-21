using Breeding_station.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breeding_station.Model.Class
{
    internal abstract class Animal : IStation, ISound
    {
        private string _type;
        private string _sex;
        private string _reproduction;
        private int _legs;
        private string _fur;
        private int _age;
        private protected bool _available;
        private protected string _sound;

        protected Animal(string type, string sex, string reproduction, int legs, string fur, int age, bool available, string sound)
        {
            _type = type;
            _sex = sex;
            _reproduction = reproduction;
            _legs = legs;
            _fur = fur;
            _age = age;
            _available = available;
            _sound = sound;
        }

        public abstract bool IsAvailable();
        public abstract string MakeSound();
        public override string ToString()
        {
            return $"Type: {_type}, Sex: {_sex}, Reproduction: {_reproduction}, Legs {_legs}, Fur: {_fur}, Age: {_age}, Is Available {_available}, Sound {_sound}\n";
        }
    }
}
